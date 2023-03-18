using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON.Prototype_Forms
{
    public partial class Đăng_Ký : Form
    {
        public Đăng_Ký()
        {
            InitializeComponent();
        }

        private void Đăng_Ký_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            External_SQL_Data_Bridge dangky = new External_SQL_Data_Bridge();

            string cau_lenh_sql = "insert into sangiaodich.dbo.nguoidung values('"+ten.Text+"',N'"+sdt.Text+" ',N'"+diachi.Text+"',N'900000000',N'0',N'"+  gt.Text +"',N'" +txt_tai_khoan.Text+ "',N'"+ txt_mat_khau.Text+"','')";
            foreach(Control tam in panel6.Controls)
            {
                if(tam.GetType()==typeof(TextBox))
                {
                    if(string.IsNullOrEmpty(tam.Text.Trim()))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                        return;
                    }
                }
            }
           if(!txt_mat_khau.Text.Equals(reenter.Text))
            {
                MessageBox.Show("Vui lòng điền lại mật khẩu chính xác");
                return;

            }
            try
            {
                dangky.chạy_lệnh_SQL(cau_lenh_sql);
                MessageBox.Show("Đăng ký thành công , vui lòng đăng nhập lại");
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn tên người dùng khác");
            }
        }
    }
}
