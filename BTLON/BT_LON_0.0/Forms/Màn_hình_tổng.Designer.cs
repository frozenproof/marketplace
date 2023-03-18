
namespace BTLON.Forms
{
    partial class Màn_hình_tổng
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
            this.bắt_đầu = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bắt_đầu
            // 
            this.bắt_đầu.Location = new System.Drawing.Point(12, 58);
            this.bắt_đầu.Name = "bắt_đầu";
            this.bắt_đầu.Size = new System.Drawing.Size(111, 47);
            this.bắt_đầu.TabIndex = 0;
            this.bắt_đầu.Text = "Bắt đầu";
            this.bắt_đầu.UseVisualStyleBackColor = true;
            this.bắt_đầu.Click += new System.EventHandler(this.bắt_đầu_Click);
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(143, 58);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(111, 47);
            this.Thoát.TabIndex = 1;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cổng thông tin";
            // 
            // Màn_hình_tổng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.bắt_đầu);
            this.Name = "Màn_hình_tổng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chào mừng";
            this.Load += new System.EventHandler(this.Màn_hình_tổng_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bắt_đầu;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.Label label1;
    }
}