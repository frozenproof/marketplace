
namespace BTLON.Forms
{
    partial class Log_In
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TênTàiKhoản = new System.Windows.Forms.TextBox();
            this.MậtKhẩu = new System.Windows.Forms.TextBox();
            this.QuênMậtKhẩu = new System.Windows.Forms.Button();
            this.ĐăngNhập = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            this.ĐăngKý = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào mừng quý khách đến với sàn chứng khoán điện tử";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu";
            // 
            // TênTàiKhoản
            // 
            this.TênTàiKhoản.Location = new System.Drawing.Point(292, 113);
            this.TênTàiKhoản.MaxLength = 10;
            this.TênTàiKhoản.Name = "TênTàiKhoản";
            this.TênTàiKhoản.Size = new System.Drawing.Size(210, 20);
            this.TênTàiKhoản.TabIndex = 2;
            // 
            // MậtKhẩu
            // 
            this.MậtKhẩu.Location = new System.Drawing.Point(292, 161);
            this.MậtKhẩu.Name = "MậtKhẩu";
            this.MậtKhẩu.PasswordChar = '*';
            this.MậtKhẩu.Size = new System.Drawing.Size(210, 20);
            this.MậtKhẩu.TabIndex = 3;
            // 
            // QuênMậtKhẩu
            // 
            this.QuênMậtKhẩu.Location = new System.Drawing.Point(12, 212);
            this.QuênMậtKhẩu.Name = "QuênMậtKhẩu";
            this.QuênMậtKhẩu.Size = new System.Drawing.Size(120, 47);
            this.QuênMậtKhẩu.TabIndex = 5;
            this.QuênMậtKhẩu.Text = "&Quên Mật Khẩu";
            this.QuênMậtKhẩu.UseVisualStyleBackColor = true;
            this.QuênMậtKhẩu.Click += new System.EventHandler(this.QuênMậtKhẩu_Click);
            // 
            // ĐăngNhập
            // 
            this.ĐăngNhập.Location = new System.Drawing.Point(173, 212);
            this.ĐăngNhập.Name = "ĐăngNhập";
            this.ĐăngNhập.Size = new System.Drawing.Size(120, 47);
            this.ĐăngNhập.TabIndex = 4;
            this.ĐăngNhập.Text = "Đăng &Nhập";
            this.ĐăngNhập.UseVisualStyleBackColor = true;
            this.ĐăngNhập.Click += new System.EventHandler(this.ĐăngNhập_Click);
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(497, 212);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(120, 47);
            this.Thoát.TabIndex = 7;
            this.Thoát.Text = "&Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // ĐăngKý
            // 
            this.ĐăngKý.Location = new System.Drawing.Point(333, 212);
            this.ĐăngKý.Name = "ĐăngKý";
            this.ĐăngKý.Size = new System.Drawing.Size(120, 47);
            this.ĐăngKý.TabIndex = 6;
            this.ĐăngKý.Text = "Đăng &Ký";
            this.ĐăngKý.UseVisualStyleBackColor = true;
            this.ĐăngKý.Click += new System.EventHandler(this.ĐăngKý_Click);
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 292);
            this.Controls.Add(this.ĐăngKý);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.ĐăngNhập);
            this.Controls.Add(this.QuênMậtKhẩu);
            this.Controls.Add(this.MậtKhẩu);
            this.Controls.Add(this.TênTàiKhoản);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Log_In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log_In";
            this.Load += new System.EventHandler(this.Log_In_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TênTàiKhoản;
        private System.Windows.Forms.TextBox MậtKhẩu;
        private System.Windows.Forms.Button QuênMậtKhẩu;
        private System.Windows.Forms.Button ĐăngNhập;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.Button ĐăngKý;
    }
}