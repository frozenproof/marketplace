
namespace BTLON.Forms
{
    partial class Đăng_ký
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
            this.Tên_tài_khoản = new System.Windows.Forms.TextBox();
            this.CMND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Họ_tên = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lại_mật_khẩu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Mật_khẩu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Số_điện_thoại = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Địa_chỉ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.xác_nhận_đăng_kí = new System.Windows.Forms.Button();
            this.Quay_lại_log_in = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Giới_tính = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // Tên_tài_khoản
            // 
            this.Tên_tài_khoản.Location = new System.Drawing.Point(151, 24);
            this.Tên_tài_khoản.Name = "Tên_tài_khoản";
            this.Tên_tài_khoản.Size = new System.Drawing.Size(212, 20);
            this.Tên_tài_khoản.TabIndex = 1;
            // 
            // CMND
            // 
            this.CMND.Location = new System.Drawing.Point(151, 199);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(212, 20);
            this.CMND.TabIndex = 5;
            this.CMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kiểm_tra_gõ_số);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số CMND";
            // 
            // Họ_tên
            // 
            this.Họ_tên.Location = new System.Drawing.Point(151, 153);
            this.Họ_tên.Name = "Họ_tên";
            this.Họ_tên.Size = new System.Drawing.Size(212, 20);
            this.Họ_tên.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ tên";
            // 
            // Lại_mật_khẩu
            // 
            this.Lại_mật_khẩu.Location = new System.Drawing.Point(151, 112);
            this.Lại_mật_khẩu.Name = "Lại_mật_khẩu";
            this.Lại_mật_khẩu.Size = new System.Drawing.Size(212, 20);
            this.Lại_mật_khẩu.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // Mật_khẩu
            // 
            this.Mật_khẩu.Location = new System.Drawing.Point(151, 66);
            this.Mật_khẩu.Name = "Mật_khẩu";
            this.Mật_khẩu.Size = new System.Drawing.Size(212, 20);
            this.Mật_khẩu.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mật khẩu";
            // 
            // Số_điện_thoại
            // 
            this.Số_điện_thoại.Location = new System.Drawing.Point(151, 244);
            this.Số_điện_thoại.Name = "Số_điện_thoại";
            this.Số_điện_thoại.Size = new System.Drawing.Size(212, 20);
            this.Số_điện_thoại.TabIndex = 6;
            this.Số_điện_thoại.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kiểm_tra_gõ_số);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số điện thoại ";
            // 
            // Địa_chỉ
            // 
            this.Địa_chỉ.Location = new System.Drawing.Point(151, 290);
            this.Địa_chỉ.Name = "Địa_chỉ";
            this.Địa_chỉ.Size = new System.Drawing.Size(212, 20);
            this.Địa_chỉ.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Địa chỉ";
            // 
            // xác_nhận_đăng_kí
            // 
            this.xác_nhận_đăng_kí.Location = new System.Drawing.Point(46, 366);
            this.xác_nhận_đăng_kí.Name = "xác_nhận_đăng_kí";
            this.xác_nhận_đăng_kí.Size = new System.Drawing.Size(137, 37);
            this.xác_nhận_đăng_kí.TabIndex = 21;
            this.xác_nhận_đăng_kí.Text = "Xác nhận";
            this.xác_nhận_đăng_kí.UseVisualStyleBackColor = true;
            this.xác_nhận_đăng_kí.Click += new System.EventHandler(this.xác_nhận_đăng_kí_Click);
            // 
            // Quay_lại_log_in
            // 
            this.Quay_lại_log_in.Location = new System.Drawing.Point(220, 366);
            this.Quay_lại_log_in.Name = "Quay_lại_log_in";
            this.Quay_lại_log_in.Size = new System.Drawing.Size(123, 37);
            this.Quay_lại_log_in.TabIndex = 22;
            this.Quay_lại_log_in.Text = "Quay Lại Log in";
            this.Quay_lại_log_in.UseVisualStyleBackColor = true;
            this.Quay_lại_log_in.Click += new System.EventHandler(this.Quay_Lại_Log_in_Click);
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(155, 425);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(75, 30);
            this.Thoát.TabIndex = 23;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Giới_tính);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Mật_khẩu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Tên_tài_khoản);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Địa_chỉ);
            this.panel1.Controls.Add(this.Họ_tên);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Số_điện_thoại);
            this.panel1.Controls.Add(this.CMND);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Lại_mật_khẩu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 365);
            this.panel1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Kiểm_tra_điền";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Giới tính";
            // 
            // Giới_tính
            // 
            this.Giới_tính.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Giới_tính.FormattingEnabled = true;
            this.Giới_tính.Location = new System.Drawing.Point(151, 330);
            this.Giới_tính.Name = "Giới_tính";
            this.Giới_tính.Size = new System.Drawing.Size(114, 21);
            this.Giới_tính.TabIndex = 22;
            this.Giới_tính.SelectedIndexChanged += new System.EventHandler(this.Giới_tính_SelectedIndexChanged);
            // 
            // Đăng_ký
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.Quay_lại_log_in);
            this.Controls.Add(this.xác_nhận_đăng_kí);
            this.Name = "Đăng_ký";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Tài Khoản";
            this.Load += new System.EventHandler(this.Đăng_ký_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tên_tài_khoản;
        private System.Windows.Forms.TextBox CMND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Họ_tên;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Lại_mật_khẩu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Mật_khẩu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Số_điện_thoại;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Địa_chỉ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button xác_nhận_đăng_kí;
        private System.Windows.Forms.Button Quay_lại_log_in;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Giới_tính;
    }
}