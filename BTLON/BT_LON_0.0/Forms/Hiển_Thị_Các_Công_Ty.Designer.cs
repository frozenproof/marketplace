
namespace BTLON.Forms
{
    partial class Hiển_Thị_Các_Công_Ty
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.table_sql_công_ty = new System.Windows.Forms.DataGridView();
            this.DateTimeText = new System.Windows.Forms.TextBox();
            this.Giao_dịch = new System.Windows.Forms.Button();
            this.Lịch_sử = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            this.Sửa_thông_tin = new System.Windows.Forms.Button();
            this.Xem_tài_khoản = new System.Windows.Forms.Button();
            this.Panel_phải = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.table_sql_công_ty)).BeginInit();
            this.Panel_phải.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // table_sql_công_ty
            // 
            this.table_sql_công_ty.AllowUserToAddRows = false;
            this.table_sql_công_ty.AllowUserToDeleteRows = false;
            this.table_sql_công_ty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_sql_công_ty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_sql_công_ty.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table_sql_công_ty.Location = new System.Drawing.Point(0, 0);
            this.table_sql_công_ty.Name = "table_sql_công_ty";
            this.table_sql_công_ty.Size = new System.Drawing.Size(786, 523);
            this.table_sql_công_ty.TabIndex = 1;
            // 
            // DateTimeText
            // 
            this.DateTimeText.BackColor = System.Drawing.Color.White;
            this.DateTimeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateTimeText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DateTimeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeText.Location = new System.Drawing.Point(0, 0);
            this.DateTimeText.Name = "DateTimeText";
            this.DateTimeText.ReadOnly = true;
            this.DateTimeText.Size = new System.Drawing.Size(179, 24);
            this.DateTimeText.TabIndex = 0;
            this.DateTimeText.TextChanged += new System.EventHandler(this.DateTimeText_TextChanged);
            // 
            // Giao_dịch
            // 
            this.Giao_dịch.Location = new System.Drawing.Point(6, 236);
            this.Giao_dịch.Name = "Giao_dịch";
            this.Giao_dịch.Size = new System.Drawing.Size(140, 35);
            this.Giao_dịch.TabIndex = 3;
            this.Giao_dịch.Text = "Giao dịch";
            this.Giao_dịch.UseVisualStyleBackColor = true;
            this.Giao_dịch.Click += new System.EventHandler(this.Giao_dịch_Click);
            // 
            // Lịch_sử
            // 
            this.Lịch_sử.Location = new System.Drawing.Point(6, 287);
            this.Lịch_sử.Name = "Lịch_sử";
            this.Lịch_sử.Size = new System.Drawing.Size(140, 35);
            this.Lịch_sử.TabIndex = 4;
            this.Lịch_sử.Text = "Lịch sử";
            this.Lịch_sử.UseVisualStyleBackColor = true;
            this.Lịch_sử.Click += new System.EventHandler(this.Lịch_sử_Click);
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(6, 408);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(140, 35);
            this.Thoát.TabIndex = 6;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // Sửa_thông_tin
            // 
            this.Sửa_thông_tin.Location = new System.Drawing.Point(6, 181);
            this.Sửa_thông_tin.Name = "Sửa_thông_tin";
            this.Sửa_thông_tin.Size = new System.Drawing.Size(140, 39);
            this.Sửa_thông_tin.TabIndex = 2;
            this.Sửa_thông_tin.Text = "Sửa thông tin";
            this.Sửa_thông_tin.UseVisualStyleBackColor = true;
            this.Sửa_thông_tin.Click += new System.EventHandler(this.Sửa_thông_tin_Click);
            // 
            // Xem_tài_khoản
            // 
            this.Xem_tài_khoản.Location = new System.Drawing.Point(6, 342);
            this.Xem_tài_khoản.Name = "Xem_tài_khoản";
            this.Xem_tài_khoản.Size = new System.Drawing.Size(140, 36);
            this.Xem_tài_khoản.TabIndex = 5;
            this.Xem_tài_khoản.Text = "Xem biểu đồ";
            this.Xem_tài_khoản.UseVisualStyleBackColor = true;
            this.Xem_tài_khoản.Click += new System.EventHandler(this.Xem_tài_khoản_Click);
            // 
            // Panel_phải
            // 
            this.Panel_phải.Controls.Add(this.Xem_tài_khoản);
            this.Panel_phải.Controls.Add(this.Sửa_thông_tin);
            this.Panel_phải.Controls.Add(this.Thoát);
            this.Panel_phải.Controls.Add(this.Lịch_sử);
            this.Panel_phải.Controls.Add(this.Giao_dịch);
            this.Panel_phải.Controls.Add(this.DateTimeText);
            this.Panel_phải.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_phải.Location = new System.Drawing.Point(796, 0);
            this.Panel_phải.Name = "Panel_phải";
            this.Panel_phải.Size = new System.Drawing.Size(179, 523);
            this.Panel_phải.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(786, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 523);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.table_sql_công_ty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 523);
            this.panel1.TabIndex = 3;
            // 
            // Hiển_Thị_Các_Công_Ty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Panel_phải);
            this.Name = "Hiển_Thị_Các_Công_Ty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Giá ";
            this.Load += new System.EventHandler(this.Hiển_Thị_Các_Công_Ty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_sql_công_ty)).EndInit();
            this.Panel_phải.ResumeLayout(false);
            this.Panel_phải.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView table_sql_công_ty;
        private System.Windows.Forms.TextBox DateTimeText;
        private System.Windows.Forms.Button Giao_dịch;
        private System.Windows.Forms.Button Lịch_sử;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.Button Sửa_thông_tin;
        private System.Windows.Forms.Button Xem_tài_khoản;
        private System.Windows.Forms.Panel Panel_phải;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
    }
}