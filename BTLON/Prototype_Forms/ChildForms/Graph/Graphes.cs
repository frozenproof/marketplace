using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BTLON.Prototype_Forms.ChildForms.Graph
{
    public partial class Graphes : Form
    {
        External_SQL_Data_Bridge External_SQL_Data_Bridge_tam = new External_SQL_Data_Bridge();
        public Graphes()
        {
            External_SQL_Data_Bridge temp_graph = new External_SQL_Data_Bridge();
            DataTable table = temp_graph.Fill_Data_Table("select * from sangiaodich.dbo.tongket where [Tên tài khoản]='" + GlobalVariable.ten_kh + "'");
            InitializeComponent();
            chart1.Series["s1"].ChartType = SeriesChartType.Pie;
            chart1.Titles.Add("Tổng kết % lượng cổ phiếu đang sở hữu");
            if (table.Rows.Count < 1)
            {
                chart1.Series["s1"].Points.AddXY("None", "20");
            }
            else
            {
                //chart1.Series["s1"].Points.AddXY("Cat", "20");
                //chart1.Series["s1"].Points.AddXY("2", "20");
                //chart1.Series["s1"].Points.AddXY("3", "120");
                //chart1.Series["s1"].Points.AddXY("4", "20");
                //chart1.Series["s1"].Points.AddXY("5", "20");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    chart1.Series["s1"].Points.AddXY(table.Rows[i].Field<string>(1), table.Rows[i].Field<long>(2));
                }
            }
            chart2.Series["s1"].ChartType = SeriesChartType.Spline;
            chart2.Titles.Add("Giá cổ phiếu theo thời gian thực");
        }

        private void Graphes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sangiaodichDataSet.congty' table. You can move, or remove it, as needed.
            this.congtyTableAdapter.Fill(this.sangiaodichDataSet.congty);
            cbo_cty.Text = "ABC";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            External_SQL_Data_Bridge sql_bash = new External_SQL_Data_Bridge();
            DataTable tbl_goc = sql_bash.Fill_Data_Table("select [Giá hiện tại] from sangiaodich.dbo.congty where [Mã kinh doanh]= '"+ cbo_cty.Text + "'");

            long chitanda = tbl_goc.Rows[0].Field<long>(0);
            if (chart2.Series["s1"].Points.Count() > 5) chart2.Series["s1"].Points.RemoveAt(0);
            //chart2.Series["s1"].Points.AddXY(table.Rows[i].Field<string>(1), table.Rows[i].Field<long>(2));
            chart2.Series["s1"].Points.AddXY(cbo_cty.Text , chitanda.ToString());

        }

        private void cbo_cty_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
        }
    }
}
