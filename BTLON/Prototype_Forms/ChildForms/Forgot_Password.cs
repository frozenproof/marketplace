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
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            External_SQL_Data_Bridge external_SQL_Data_Bridge = new External_SQL_Data_Bridge();
            DataTable bruh = external_SQL_Data_Bridge.Fill_Data_Table("select [Mật khẩu] from sangiaodich.dbo.nguoidung where [Tên tài khoản]='"+txt_tai_khoan.Text +"'");
            try
            {
                txt_mat_khau.Text = bruh.Rows[0].Field<string>(0);
            }
            catch
            {
                MessageBox.Show("Không tồn tại tài khoản");
            }
            GlobalVariable.global_thử_Nghiệm_Main_Menu.Open_child_form(new Đăng_Nhập());
            GlobalVariable.global_thử_Nghiệm_Main_Menu.Refresh();
        }
    }
}
