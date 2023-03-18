using System;
using System.Data;
using System.Windows.Forms;

namespace BTLON.Forms
{
    public partial class Lịch_sử_giao_dịch : Form
    {
        External_SQL_Data_Bridge lịch_sử_giao_dịch_External_SQL_Data_Bridge = new External_SQL_Data_Bridge();
        public Lịch_sử_giao_dịch()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lịch_sử_giao_dịch_Load(object sender, EventArgs e)
        {
            string lấy_lịch_sử_giao_dịch = "";
            DataTable lịch_sử_giao_dịch = lịch_sử_giao_dịch_External_SQL_Data_Bridge.Fill_Data_Table(lấy_lịch_sử_giao_dịch);
            bảng_lịch_sử_giao_dịch.DataSource = lịch_sử_giao_dịch;
        }
    }
}
