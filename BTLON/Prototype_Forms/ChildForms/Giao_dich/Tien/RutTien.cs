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
    public partial class RutTien : Form
    {
        public RutTien()
        {
            InitializeComponent();
        }

        private void RutTien_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        private void btn_rut_tien_Click(object sender, EventArgs e)
        {
              External_SQL_Data_Bridge temp_nap = new External_SQL_Data_Bridge();
            double tam_tien = long.Parse(txt_tien.Text) + long.Parse(txt_phi.Text) * 0.015;
            DataTable temp_table = temp_nap.Fill_Data_Table("select [Số dư] from sangiaodich.dbo.nguoidung where [Tên tài khoản]= '" + GlobalVariable.ten_kh + "'");
            double thucte = temp_table.Rows[0].Field<long>(0);
            txt_so_du.Text = thucte.ToString();
            long thuc = (long)(thucte - tam_tien);
            temp_nap.chạy_lệnh_SQL("update sangiaodich.dbo.nguoidung set [Số dư] = '" + thuc + "' where [Tên tài khoản]='" + GlobalVariable.ten_kh + "'");
            
            //try
            //{
            //    temp_nap.chạy_lệnh_SQL("update sangiaodich.dbo.nguoidung set [Số dư] = [Số dư] - '" + tien_rut_thuc + "' where [Tên tài khoản]='" + GlobalVariable.ten_kh + "'");
            //    MessageBox.Show("update sangiaodich.dbo.nguoidung set [Số dư] = [Số dư] - '" + tien_rut_thuc + "' where [Tên tài khoản]='" + GlobalVariable.ten_kh + "'");
            //}
            //catch
            //{
            //    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            //    GlobalVariable.global_thử_Nghiệm_Main_Menu.Refresh();
            //}
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_tien.Text = "";
            txt_phi.Text = "";
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
        private void hienthi()
        {
            External_SQL_Data_Bridge tempcheck = new External_SQL_Data_Bridge();
            DataTable temp_table = tempcheck.Fill_Data_Table("select [Số dư] from sangiaodich.dbo.nguoidung where [Tên tài khoản]= '" + GlobalVariable.ten_kh + "'");
            double thucte = temp_table.Rows[0].Field<long>(0);
            txt_so_du.Text = thucte.ToString();
        }
        private void txt_tien_TextChanged(object sender, EventArgs e)
        {
            External_SQL_Data_Bridge tempcheck = new External_SQL_Data_Bridge();
            DataTable temp_table = tempcheck.Fill_Data_Table("select [Số dư] from sangiaodich.dbo.nguoidung where [Tên tài khoản]= '" + GlobalVariable.ten_kh + "'");
            double thucte = temp_table.Rows[0].Field<long>(0);
            double duoc_phep_rut = thucte * 0.985;
            txt_so_du.Text = thucte.ToString();
            try
            {
                txt_phi.Text = (float.Parse(txt_tien.Text) * 0.015).ToString();
            }
            catch
            {

            }
            if(long.Parse(txt_tien.Text)>duoc_phep_rut)
            {
                MessageBox.Show("Không đủ tiền để rút vì tiền phí.");
                txt_tien.Text = "0";
            }
        }
    }
}
