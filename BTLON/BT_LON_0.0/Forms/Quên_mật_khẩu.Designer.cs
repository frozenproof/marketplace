
namespace BTLON.Forms
{
    partial class Quên_mật_khẩu
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
            this.label1 = new System.Windows.Forms.Label();
            this.Xác_nhận = new System.Windows.Forms.Button();
            this.Quay_lại_Đăng_nhập = new System.Windows.Forms.Button();
            this.số_điện_thoại = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tên_tài_khoản = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại";
            // 
            // Xác_nhận
            // 
            this.Xác_nhận.Location = new System.Drawing.Point(35, 95);
            this.Xác_nhận.Name = "Xác_nhận";
            this.Xác_nhận.Size = new System.Drawing.Size(99, 36);
            this.Xác_nhận.TabIndex = 1;
            this.Xác_nhận.Text = "Xác nhận";
            this.Xác_nhận.UseVisualStyleBackColor = true;
            this.Xác_nhận.Click += new System.EventHandler(this.Xác_nhận_Click);
            // 
            // Quay_lại_Đăng_nhập
            // 
            this.Quay_lại_Đăng_nhập.Location = new System.Drawing.Point(209, 95);
            this.Quay_lại_Đăng_nhập.Name = "Quay_lại_Đăng_nhập";
            this.Quay_lại_Đăng_nhập.Size = new System.Drawing.Size(111, 36);
            this.Quay_lại_Đăng_nhập.TabIndex = 2;
            this.Quay_lại_Đăng_nhập.Text = "Quay lại Đăng nhập";
            this.Quay_lại_Đăng_nhập.UseVisualStyleBackColor = true;
            this.Quay_lại_Đăng_nhập.Click += new System.EventHandler(this.Quay_lại_Đăng_nhập_Click);
            // 
            // số_điện_thoại
            // 
            this.số_điện_thoại.Location = new System.Drawing.Point(148, 48);
            this.số_điện_thoại.Name = "số_điện_thoại";
            this.số_điện_thoại.Size = new System.Drawing.Size(170, 20);
            this.số_điện_thoại.TabIndex = 3;
            this.số_điện_thoại.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.số_điện_thoại_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên tài khoản";
            // 
            // Tên_tài_khoản
            // 
            this.Tên_tài_khoản.Location = new System.Drawing.Point(148, 16);
            this.Tên_tài_khoản.Name = "Tên_tài_khoản";
            this.Tên_tài_khoản.Size = new System.Drawing.Size(170, 20);
            this.Tên_tài_khoản.TabIndex = 5;
            // 
            // Quên_mật_khẩu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 160);
            this.Controls.Add(this.Tên_tài_khoản);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.số_điện_thoại);
            this.Controls.Add(this.Quay_lại_Đăng_nhập);
            this.Controls.Add(this.Xác_nhận);
            this.Controls.Add(this.label1);
            this.Name = "Quên_mật_khẩu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên_mật_khẩu";
            this.Load += new System.EventHandler(this.Quên_mật_khẩu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Xác_nhận;
        private System.Windows.Forms.Button Quay_lại_Đăng_nhập;
        private System.Windows.Forms.TextBox số_điện_thoại;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tên_tài_khoản;
    }
}