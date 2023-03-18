using System;
using System.Windows.Forms;

namespace BTLON
{
    public partial class Khung_thông_báo : Form
    {
        public Khung_thông_báo()
        {
            InitializeComponent();
        }

        private void Just_text_Load(object sender, EventArgs e)
        {

        }
        public void đặt_tên(string tên,string mật_khẩu)
        {
            this.Text = tên;
            hiển_thị.Text = mật_khẩu;
        }
        public void block()
        {
            hiển_thị.Enabled = false;
        }
        private void Đồng_ý_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
