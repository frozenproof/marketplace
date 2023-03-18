using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON.Prototype_Forms.Forms
{
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalVariable.global_thử_Nghiệm_Main_Menu.Open_child_form(new Account());
            GlobalVariable.global_thử_Nghiệm_Main_Menu.Refresh();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if(txt_mat_khau.Text.Trim()==reeenter.Text.Trim())
            {
                string lenh_sql = "update sangiaodich.dbo.nguoidung set [Mật khẩu] = '" + txt_mat_khau.Text.Trim() + "' where  [Tên tài khoản] = '"+GlobalVariable.ten_kh+"'";
                External_SQL_Data_Bridge chay = new External_SQL_Data_Bridge();
                chay.chạy_lệnh_SQL(lenh_sql);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
    }
}
