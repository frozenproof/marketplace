
namespace BTLON.Forms
{
    partial class Lịch_sử_giao_dịch
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
            this.đóng_form = new System.Windows.Forms.Button();
            this.bảng_lịch_sử_giao_dịch = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bảng_lịch_sử_giao_dịch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // đóng_form
            // 
            this.đóng_form.Location = new System.Drawing.Point(275, 23);
            this.đóng_form.Name = "đóng_form";
            this.đóng_form.Size = new System.Drawing.Size(75, 23);
            this.đóng_form.TabIndex = 0;
            this.đóng_form.Text = "Ok";
            this.đóng_form.UseVisualStyleBackColor = true;
            this.đóng_form.Click += new System.EventHandler(this.Close_Click);
            // 
            // bảng_lịch_sử_giao_dịch
            // 
            this.bảng_lịch_sử_giao_dịch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bảng_lịch_sử_giao_dịch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bảng_lịch_sử_giao_dịch.Location = new System.Drawing.Point(0, 0);
            this.bảng_lịch_sử_giao_dịch.Name = "bảng_lịch_sử_giao_dịch";
            this.bảng_lịch_sử_giao_dịch.Size = new System.Drawing.Size(645, 344);
            this.bảng_lịch_sử_giao_dịch.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.đóng_form);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 62);
            this.panel1.TabIndex = 2;
            // 
            // Lịch_sử_giao_dịch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 344);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bảng_lịch_sử_giao_dịch);
            this.Name = "Lịch_sử_giao_dịch";
            this.Text = "`";
            this.Load += new System.EventHandler(this.Lịch_sử_giao_dịch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bảng_lịch_sử_giao_dịch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button đóng_form;
        private System.Windows.Forms.DataGridView bảng_lịch_sử_giao_dịch;
        private System.Windows.Forms.Panel panel1;
    }
}