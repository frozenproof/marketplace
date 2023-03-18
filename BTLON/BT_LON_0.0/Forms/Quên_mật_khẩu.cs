using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON.Forms
{
    public partial class Quên_mật_khẩu : Form
    {
        External_SQL_Data_Bridge quên_mật_khẩu_External_SQL_Data_Bridge = new External_SQL_Data_Bridge();
        public Quên_mật_khẩu()
        {
            InitializeComponent();
        }

        private void Xác_nhận_Click(object sender, EventArgs e)
        {
            if(kiểm_tra_trống())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            string lấy_mật_khẩu_dựa_trên_số_điện_thoại_và_tên = "select [Mật khẩu] from Sangiaodich.dbo.nguoidung where [Số điện thoại liên lạc]=N'"+số_điện_thoại.Text+"' and [Tên tài khoản]= N'"+Tên_tài_khoản.Text+"'";
            DataTable lấy_mật_khẩu= quên_mật_khẩu_External_SQL_Data_Bridge.Fill_Data_Table(lấy_mật_khẩu_dựa_trên_số_điện_thoại_và_tên);
            //SQL_Command_Testing_Pop_Up temp = new SQL_Command_Testing_Pop_Up();
            //temp.setTable(lấy_mật_khẩu);
            //temp.Show();
            if (Kho.hiện.IsDisposed)
            {
                Kho.hiện = new Khung_thông_báo();
            }
            Kho.hiện.đặt_tên("Mật khẩu", lấy_mật_khẩu.Rows[0].Field<string>(0));
            Kho.hiện.Show();
        }

        private void Quay_lại_Đăng_nhập_Click(object sender, EventArgs e)
        {
            if (Kho.log_in.IsDisposed)
                Kho.log_in = new Log_In();
            Kho.log_in.Show();
            Kho.quên_Mật_Khẩu.Close();
        }

        private void số_điện_thoại_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        private bool kiểm_tra_trống()
        {
            foreach (Control control in Kho.quên_Mật_Khẩu.Controls)
            {
                if (control.Text == "")
                {
                    return true;
                }
            }
            return false;
        }

        private void Quên_mật_khẩu_Load(object sender, EventArgs e)
        {
            số_điện_thoại.Text = "0999000003";
            Tên_tài_khoản.Text = "meo";
        }
    }
}
