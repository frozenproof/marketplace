
namespace BTLON.Prototype_Forms.ChildForms.Graph
{
    partial class Graphes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbo_cty = new System.Windows.Forms.ComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sangiaodichDataSet = new BTLON.sangiaodichDataSet();
            this.congtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.congtyTableAdapter = new BTLON.sangiaodichDataSetTableAdapters.congtyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangiaodichDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congtyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 38);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series11.Legend = "Legend1";
            series11.Name = "s1";
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(591, 412);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.chart1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.chart2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(619, 581);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbo_cty);
            this.panel2.Location = new System.Drawing.Point(3, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 54);
            this.panel2.TabIndex = 2;
            // 
            // cbo_cty
            // 
            this.cbo_cty.DataSource = this.sangiaodichDataSet;
            this.cbo_cty.DisplayMember = "congty.Mã kinh doanh";
            this.cbo_cty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cty.FormattingEnabled = true;
            this.cbo_cty.Location = new System.Drawing.Point(24, 19);
            this.cbo_cty.Name = "cbo_cty";
            this.cbo_cty.Size = new System.Drawing.Size(232, 21);
            this.cbo_cty.TabIndex = 0;
            this.cbo_cty.SelectedIndexChanged += new System.EventHandler(this.cbo_cty_SelectedIndexChanged);
            // 
            // chart2
            // 
            chartArea12.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart2.Legends.Add(legend12);
            this.chart2.Location = new System.Drawing.Point(3, 481);
            this.chart2.Name = "chart2";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "s1";
            this.chart2.Series.Add(series12);
            this.chart2.Size = new System.Drawing.Size(591, 412);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sangiaodichDataSet
            // 
            this.sangiaodichDataSet.DataSetName = "sangiaodichDataSet";
            this.sangiaodichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // congtyBindingSource
            // 
            this.congtyBindingSource.DataMember = "congty";
            this.congtyBindingSource.DataSource = this.sangiaodichDataSet;
            // 
            // congtyTableAdapter
            // 
            this.congtyTableAdapter.ClearBeforeFill = true;
            // 
            // Graphes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 619);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Graphes";
            this.Text = "Graphes";
            this.Load += new System.EventHandler(this.Graphes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangiaodichDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congtyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ComboBox cbo_cty;
        private System.Windows.Forms.Timer timer1;
        private sangiaodichDataSet sangiaodichDataSet;
        private System.Windows.Forms.BindingSource congtyBindingSource;
        private sangiaodichDataSetTableAdapters.congtyTableAdapter congtyTableAdapter;
    }
}