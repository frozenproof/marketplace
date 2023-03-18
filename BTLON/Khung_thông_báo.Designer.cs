
namespace BTLON
{
    partial class Khung_thông_báo
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
            this.hiển_thị = new System.Windows.Forms.TextBox();
            this.Đồng_ý = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hiển_thị
            // 
            this.hiển_thị.Location = new System.Drawing.Point(18, 12);
            this.hiển_thị.Name = "hiển_thị";
            this.hiển_thị.Size = new System.Drawing.Size(196, 20);
            this.hiển_thị.TabIndex = 0;
            // 
            // Đồng_ý
            // 
            this.Đồng_ý.Location = new System.Drawing.Point(39, 41);
            this.Đồng_ý.Name = "Đồng_ý";
            this.Đồng_ý.Size = new System.Drawing.Size(152, 24);
            this.Đồng_ý.TabIndex = 1;
            this.Đồng_ý.Text = "Ok";
            this.Đồng_ý.UseVisualStyleBackColor = true;
            this.Đồng_ý.Click += new System.EventHandler(this.Đồng_ý_Click);
            // 
            // Just_text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 70);
            this.Controls.Add(this.Đồng_ý);
            this.Controls.Add(this.hiển_thị);
            this.Name = "Just_text";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just_text";
            this.Load += new System.EventHandler(this.Just_text_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hiển_thị;
        private System.Windows.Forms.Button Đồng_ý;
    }
}