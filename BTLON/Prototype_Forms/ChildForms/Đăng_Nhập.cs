using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON.Prototype_Forms.ChildForms
{
    public partial class Đăng_Nhập : Form
    {
        public Đăng_Nhập()
        {
            InitializeComponent();
        }

        private void btn_log_in_Click(object sender, EventArgs e)
        {
            SQL_CONNECT.Portal.cổng = new External_SQL_Data_Bridge();
            DataTable log_in = SQL_CONNECT.Portal.cổng.Fill_Data_Table("select * from sangiaodich.dbo.nguoidung where [Tên tài khoản] = N'"+ txt_tai_khoan.Text.Trim() +"'");
            //SQL_Command_Testing_Pop_Up tam = new SQL_Command_Testing_Pop_Up();
            //tam.setTable(log_in);
            //tam.Show();
            bool check=true;
            foreach(Control temp in this.Controls)
            {
                if(temp is TextBox)
                {
                    if(string.IsNullOrEmpty(temp.Text))
                    {
                        GlobalVariable.global_thử_Nghiệm_Main_Menu.Refresh();
                        MessageBox.Show("Please fill all fields!");
                        check = false;
                        break;
                    }
                }
            }
            if (check==true)
            if(log_in.Rows.Count==0)
            {
                MessageBox.Show("Couldn't find the user!");
            }
            else
            {
                if (password_check(log_in))
                {
                    GlobalVariable.ten_kh = txt_tai_khoan.Text.Trim();
                    MessageBox.Show("Welcome, User "+txt_tai_khoan.Text.Trim());
                    ActivateMenu();
                }
                else
                {
                    MessageBox.Show("Wrong password!");
                }
            }
            GlobalVariable.global_thử_Nghiệm_Main_Menu.Refresh();

        }

        private void ActivateMenu()
        {
            GlobalVariable.global_thử_Nghiệm_Main_Menu.ActivateMenuTN();
        }

        private bool password_check(DataTable log_in)
        {
            //foreach (DataRow o in log_in.Select("[Mật khẩu] == N'" + txt_mat_khau.Text + "'"))
            foreach (DataRow o in log_in.Select("[Mật khẩu] = '" + txt_mat_khau.Text.Trim() + "'"))
            {
                return true;
            }
            return false;
        }
        private void Đăng_Nhập_Load(object sender, EventArgs e)
        {

        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            GlobalVariable.global_thử_Nghiệm_Main_Menu.Open_child_form(new Đăng_Ký());
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            GlobalVariable.global_thử_Nghiệm_Main_Menu.Open_child_form(new Forgot_Password());
        }
    }
}
