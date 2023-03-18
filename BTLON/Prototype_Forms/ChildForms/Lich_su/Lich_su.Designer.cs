
namespace BTLON.Prototype_Forms.ChildForms.Lich_su
{
    partial class Lich_su
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
            this.btn_report = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_reset_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cp_gd = new System.Windows.Forms.TextBox();
            this.cbo_cp_gd = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.History_table = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.History_table)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(9, 14);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(122, 41);
            this.btn_report.TabIndex = 1;
            this.btn_report.Text = "Make a report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_reset_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_cp_gd);
            this.panel1.Controls.Add(this.cbo_cp_gd);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 68);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_report);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(666, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 68);
            this.panel2.TabIndex = 19;
            // 
            // btn_reset_search
            // 
            this.btn_reset_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.btn_reset_search.ForeColor = System.Drawing.Color.White;
            this.btn_reset_search.Location = new System.Drawing.Point(165, 37);
            this.btn_reset_search.Name = "btn_reset_search";
            this.btn_reset_search.Size = new System.Drawing.Size(49, 21);
            this.btn_reset_search.TabIndex = 18;
            this.btn_reset_search.Text = "Reset";
            this.btn_reset_search.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã giao dịch cần tìm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(239, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số cổ phần giao dịch";
            // 
            // txt_cp_gd
            // 
            this.txt_cp_gd.Location = new System.Drawing.Point(393, 25);
            this.txt_cp_gd.Name = "txt_cp_gd";
            this.txt_cp_gd.Size = new System.Drawing.Size(73, 20);
            this.txt_cp_gd.TabIndex = 12;
            this.txt_cp_gd.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cbo_cp_gd
            // 
            this.cbo_cp_gd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cp_gd.FormattingEnabled = true;
            this.cbo_cp_gd.Items.AddRange(new object[] {
            ">",
            "<"});
            this.cbo_cp_gd.Location = new System.Drawing.Point(353, 25);
            this.cbo_cp_gd.Name = "cbo_cp_gd";
            this.cbo_cp_gd.Size = new System.Drawing.Size(34, 21);
            this.cbo_cp_gd.TabIndex = 11;
            this.cbo_cp_gd.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // txt_search
            // 
            this.txt_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_search.Location = new System.Drawing.Point(69, 38);
            this.txt_search.MaxLength = 3;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(67, 20);
            this.txt_search.TabIndex = 10;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // History_table
            // 
            this.History_table.AllowUserToAddRows = false;
            this.History_table.AllowUserToDeleteRows = false;
            this.History_table.AllowUserToResizeRows = false;
            this.History_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.History_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.History_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.History_table.Location = new System.Drawing.Point(0, 68);
            this.History_table.Name = "History_table";
            this.History_table.ReadOnly = true;
            this.History_table.Size = new System.Drawing.Size(800, 382);
            this.History_table.TabIndex = 3;
            // 
            // Lich_su
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.History_table);
            this.Controls.Add(this.panel1);
            this.Name = "Lich_su";
            this.Text = "Lich_su";
            this.Load += new System.EventHandler(this.Lich_su_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.History_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_reset_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cp_gd;
        private System.Windows.Forms.ComboBox cbo_cp_gd;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView History_table;
        private System.Windows.Forms.Panel panel2;
    }
}