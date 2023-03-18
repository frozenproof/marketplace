using BTLON.SQL_CONNECT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTLON.Prototype_Forms.ChildForms.Theo_doi
{
    public partial class TheoDoi : Form
    {
        public TheoDoi()
        {
            InitializeComponent();
        }

        private void TheoDoi_Load(object sender, EventArgs e)
        {
            TableCompany.RowHeadersVisible = false;
            TableCompany.DataSource = Portal.cổng.Fill_Data_Table("select [Mã kinh doanh],[Giá hiện tại],[Giá tham chiếu],[Giá trần],[Giá sàn],[Số cổ phần available] as [Số cổ phần giao dịch] from sangiaodich.dbo.congty");
            TableCompany.AllowUserToAddRows = false;
        }

        private void TableCompany_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.ColumnIndex > 4 && e.Value != null)
            {
                e.CellStyle.BackColor = Color.Black;
                e.CellStyle.ForeColor = Color.White;
            }
            else
            {
                e.CellStyle.BackColor = Color.Black;
            }
            foreach (DataGridViewRow row in TableCompany.Rows)
            {
                if (Convert.ToInt32(row.Cells[1].Value) > (Convert.ToInt32(row.Cells[2].Value)))
                {
                    row.Cells[0].Style.ForeColor = Color.LightGreen;
                    row.Cells[1].Style.ForeColor = Color.LightGreen;
                }
                else
                {
                    row.Cells[0].Style.ForeColor = Color.FromArgb(203, 18, 37);
                    row.Cells[1].Style.ForeColor = Color.FromArgb(203, 18, 37);
                }
            }

            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.CellStyle.ForeColor = Color.FromArgb(253, 239, 50);
            }
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.CellStyle.ForeColor = Color.FromArgb(212, 57, 237);
            }
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.CellStyle.ForeColor = Color.FromArgb(22, 168, 255);
            }
        }
    }
}
