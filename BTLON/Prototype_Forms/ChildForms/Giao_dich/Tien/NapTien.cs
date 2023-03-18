using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON.Prototype_Forms.ChildForms.Giao_dich.Tien
{
    public partial class NapTien : Form
    {
        public string loai_gd = "";
        public NapTien()
        {
            InitializeComponent();
        }

        private void NapTien_Load(object sender, EventArgs e)
        {
            cbo_loai.SelectedIndex = 0;
        }

        private void btn_nap_tien_Click(object sender, EventArgs e)
        {
            if (txt_tien.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            if (loai_gd == "nap")
                naptien();
            if (loai_gd == "vay")
                vaytien();
            if (loai_gd == "tra")
                trano();
        }

        private void trano()
        {
            External_SQL_Data_Bridge temp_nap = new External_SQL_Data_Bridge();
            long tong = long.Parse(txt_tien.Text);
            long tien_phi = (long)double.Parse(txt_phi.Text);
            long tinhtam = tong - tien_phi;
            DataTable temp_table = new DataTable();
            temp_table = temp_nap.Fill_Data_Table("select * from sangiaodich.dbo.nguoidung where [Tên tài khoản]='" + GlobalVariable.ten_kh + "'");
            long no = temp_table.Rows[0].Field<long>(4);
            no = no - tinhtam;
            if (no >= 0)
                temp_nap.chạy_lệnh_SQL("update sangiaodich.dbo.nguoidung set [Số tiền nợ] = [Số tiền nợ] - '" + tinhtam.ToString() + "' where [Tên tài khoản]='" + GlobalVariable.ten_kh + "'");
            if (no < 0)
                temp_nap.chạy_lệnh_SQL("update sangiaodich.dbo.nguoidung set [Số dư] = [Số dư] + '" + Math.Abs(no)+ "',[Số tiền nợ]=0 where [Tên tài khoản]='" + GlobalVariable.ten_kh + "'");
        }

        private void vaytien()
        {
            External_SQL_Data_Bridge temp_nap = new External_SQL_Data_Bridge();
            long tong = long.Parse(txt_tien.Text);
            long tien_phi = (long)double.Parse(txt_phi.Text);
            long tinhtam = tong - tien_phi;
            temp_nap.chạy_lệnh_SQL("update sangiaodich.dbo.nguoidung set [Số dư] = [Số dư]+ '" + tinhtam.ToString() + "',[Số tiền nợ] = [Số tiền nợ] + '" + txt_tien.Text + "' where [Tên tài khoản] = '" + GlobalVariable.ten_kh + "'");
        }

        public void naptien()
        {
            External_SQL_Data_Bridge temp_nap = new External_SQL_Data_Bridge();
            long tong = long.Parse(txt_tien.Text);
            long tien_phi =(long) double.Parse(txt_phi.Text);
            long tinhtam = tong - tien_phi;
            temp_nap.chạy_lệnh_SQL("update sangiaodich.dbo.nguoidung set [Số dư] = [Số dư]+ '" + tinhtam.ToString() + "' where [Tên tài khoản]='" + GlobalVariable.ten_kh + "'");
            //MessageBox.Show("update sangiaodich.dbo.nguoidung set [Số dư] = [Số dư]+ '" + tinhtam.ToString() + "' where [Tên tài khoản]='" + GlobalVariable.ten_kh + "'");
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_tien.Text = "";
            txt_phi.Text = "";
        }

        private void txt_tien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_phi.Text = (float.Parse(txt_tien.Text) * 0.015).ToString();
            }
            catch
            {

            }
        }

        private void txt_tien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CommonFormFunctions.isNumber(e.KeyChar.ToString()) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void cbo_loai_TextChanged(object sender, EventArgs e)
        {
            if (cbo_loai.Text == "Nạp tiền")
            {
                loai_gd = "nap";
            }
            if (cbo_loai.Text == "Vay tiền")
            {
                loai_gd = "vay";
            }
            if (cbo_loai.Text == "Trả nợ")
            {
                loai_gd = "tra";
            }
        }
    }
}
