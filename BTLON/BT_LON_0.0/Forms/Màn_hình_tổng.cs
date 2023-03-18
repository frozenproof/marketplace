using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON.Forms
{
    public partial class Màn_hình_tổng : Form
    {
        public Màn_hình_tổng()
        {
            InitializeComponent();
        }

        private void Màn_hình_tổng_Load(object sender, EventArgs e)
        {

        }

        private void bắt_đầu_Click(object sender, EventArgs e)
        {
            if (Kho.log_in.IsDisposed)
                Kho.log_in = new Log_In();
            Kho.log_in.Show();
            //Kho.màn_Hình_Tổng.Hide();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
       MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
    }
}
