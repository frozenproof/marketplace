
namespace BTLON.Forms
{
    partial class Giao_dịch
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
            this.Số_tiền_giao_dịch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loại_giao_dịch = new System.Windows.Forms.ComboBox();
            this.lbl_giao_dịch = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.số_cổ_phiếu_giao_dịch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Phí_giao_dịch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ghi_chú = new System.Windows.Forms.TextBox();
            this.Quay_lại_giao_dịch = new System.Windows.Forms.Button();
            this.Xác_nhận_giao_dịch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mã_công_ty = new System.Windows.Forms.DataGridView();
            this.txt_tổng_giao_dịch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mã_công_ty)).BeginInit();
            this.SuspendLayout();
            // 
            // Số_tiền_giao_dịch
            // 
            this.Số_tiền_giao_dịch.Location = new System.Drawing.Point(171, 53);
            this.Số_tiền_giao_dịch.Name = "Số_tiền_giao_dịch";
            this.Số_tiền_giao_dịch.Size = new System.Drawing.Size(178, 20);
            this.Số_tiền_giao_dịch.TabIndex = 0;
            this.Số_tiền_giao_dịch.TextChanged += new System.EventHandler(this.Số_tiền_giao_dịch_TextChanged);
            this.Số_tiền_giao_dịch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kiểm_tra_gõ_số);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số tiền giao dịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại giao dịch";
            // 
            // loại_giao_dịch
            // 
            this.loại_giao_dịch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loại_giao_dịch.FormattingEnabled = true;
            this.loại_giao_dịch.Location = new System.Drawing.Point(171, 99);
            this.loại_giao_dịch.Name = "loại_giao_dịch";
            this.loại_giao_dịch.Size = new System.Drawing.Size(121, 21);
            this.loại_giao_dịch.TabIndex = 3;
            this.loại_giao_dịch.SelectedIndexChanged += new System.EventHandler(this.loại_giao_dịch_SelectedIndexChanged);
            // 
            // lbl_giao_dịch
            // 
            this.lbl_giao_dịch.AutoSize = true;
            this.lbl_giao_dịch.Location = new System.Drawing.Point(82, 149);
            this.lbl_giao_dịch.Name = "lbl_giao_dịch";
            this.lbl_giao_dịch.Size = new System.Drawing.Size(52, 13);
            this.lbl_giao_dịch.TabIndex = 4;
            this.lbl_giao_dịch.Text = "Giao dịch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phí giao dịch";
            // 
            // số_cổ_phiếu_giao_dịch
            // 
            this.số_cổ_phiếu_giao_dịch.Location = new System.Drawing.Point(171, 13);
            this.số_cổ_phiếu_giao_dịch.Name = "số_cổ_phiếu_giao_dịch";
            this.số_cổ_phiếu_giao_dịch.Size = new System.Drawing.Size(120, 20);
            this.số_cổ_phiếu_giao_dịch.TabIndex = 11;
            this.số_cổ_phiếu_giao_dịch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kiểm_tra_gõ_số);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số cổ phiếu giao dịch";
            // 
            // Phí_giao_dịch
            // 
            this.Phí_giao_dịch.Location = new System.Drawing.Point(171, 326);
            this.Phí_giao_dịch.Name = "Phí_giao_dịch";
            this.Phí_giao_dịch.ReadOnly = true;
            this.Phí_giao_dịch.Size = new System.Drawing.Size(178, 20);
            this.Phí_giao_dịch.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ghi chú giao dịch";
            // 
            // ghi_chú
            // 
            this.ghi_chú.Location = new System.Drawing.Point(171, 405);
            this.ghi_chú.Multiline = true;
            this.ghi_chú.Name = "ghi_chú";
            this.ghi_chú.Size = new System.Drawing.Size(178, 61);
            this.ghi_chú.TabIndex = 14;
            // 
            // Quay_lại_giao_dịch
            // 
            this.Quay_lại_giao_dịch.Location = new System.Drawing.Point(250, 507);
            this.Quay_lại_giao_dịch.Name = "Quay_lại_giao_dịch";
            this.Quay_lại_giao_dịch.Size = new System.Drawing.Size(75, 54);
            this.Quay_lại_giao_dịch.TabIndex = 15;
            this.Quay_lại_giao_dịch.Text = "Quay lại bảng giá";
            this.Quay_lại_giao_dịch.UseVisualStyleBackColor = true;
            this.Quay_lại_giao_dịch.Click += new System.EventHandler(this.Quay_lại_giao_dịch_Click);
            // 
            // Xác_nhận_giao_dịch
            // 
            this.Xác_nhận_giao_dịch.Location = new System.Drawing.Point(46, 507);
            this.Xác_nhận_giao_dịch.Name = "Xác_nhận_giao_dịch";
            this.Xác_nhận_giao_dịch.Size = new System.Drawing.Size(71, 48);
            this.Xác_nhận_giao_dịch.TabIndex = 17;
            this.Xác_nhận_giao_dịch.Text = "Xác nhận giao dịch";
            this.Xác_nhận_giao_dịch.UseVisualStyleBackColor = true;
            this.Xác_nhận_giao_dịch.Click += new System.EventHandler(this.Xác_nhận_giao_dịch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_tổng_giao_dịch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mã_công_ty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Số_tiền_giao_dịch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ghi_chú);
            this.panel1.Controls.Add(this.loại_giao_dịch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbl_giao_dịch);
            this.panel1.Controls.Add(this.Phí_giao_dịch);
            this.panel1.Controls.Add(this.số_cổ_phiếu_giao_dịch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 500);
            this.panel1.TabIndex = 18;
            // 
            // mã_công_ty
            // 
            this.mã_công_ty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mã_công_ty.Location = new System.Drawing.Point(99, 164);
            this.mã_công_ty.Name = "mã_công_ty";
            this.mã_công_ty.Size = new System.Drawing.Size(237, 143);
            this.mã_công_ty.TabIndex = 15;
            this.mã_công_ty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mã_công_ty_CellClick);
            // 
            // txt_tổng_giao_dịch
            // 
            this.txt_tổng_giao_dịch.Location = new System.Drawing.Point(171, 367);
            this.txt_tổng_giao_dịch.Name = "txt_tổng_giao_dịch";
            this.txt_tổng_giao_dịch.ReadOnly = true;
            this.txt_tổng_giao_dịch.Size = new System.Drawing.Size(178, 20);
            this.txt_tổng_giao_dịch.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tổng giao dịch";
            // 
            // Giao_dịch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Xác_nhận_giao_dịch);
            this.Controls.Add(this.Quay_lại_giao_dịch);
            this.Name = "Giao_dịch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao_dịch";
            this.Load += new System.EventHandler(this.Giao_dịch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mã_công_ty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Số_tiền_giao_dịch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox loại_giao_dịch;
        private System.Windows.Forms.Label lbl_giao_dịch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox số_cổ_phiếu_giao_dịch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Phí_giao_dịch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ghi_chú;
        private System.Windows.Forms.Button Quay_lại_giao_dịch;
        private System.Windows.Forms.Button Xác_nhận_giao_dịch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView mã_công_ty;
        private System.Windows.Forms.TextBox txt_tổng_giao_dịch;
        private System.Windows.Forms.Label label3;
    }
}