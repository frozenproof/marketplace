
namespace BTLON.Prototype_Forms.ChildForms
{
    partial class Đăng_Nhập
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
            this.txt_tai_khoan = new System.Windows.Forms.TextBox();
            this.txt_mat_khau = new System.Windows.Forms.TextBox();
            this.btn_log_in = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sign_up = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_log_in.SuspendLayout();
            this.btn_sign_up.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_tai_khoan
            // 
            this.txt_tai_khoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tai_khoan.Location = new System.Drawing.Point(153, 36);
            this.txt_tai_khoan.Name = "txt_tai_khoan";
            this.txt_tai_khoan.Size = new System.Drawing.Size(192, 31);
            this.txt_tai_khoan.TabIndex = 2;
            this.txt_tai_khoan.Text = "meo";
            // 
            // txt_mat_khau
            // 
            this.txt_mat_khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat_khau.Location = new System.Drawing.Point(153, 99);
            this.txt_mat_khau.Name = "txt_mat_khau";
            this.txt_mat_khau.PasswordChar = '*';
            this.txt_mat_khau.Size = new System.Drawing.Size(192, 31);
            this.txt_mat_khau.TabIndex = 6;
            this.txt_mat_khau.Text = "123456";
            // 
            // btn_log_in
            // 
            this.btn_log_in.Controls.Add(this.button1);
            this.btn_log_in.Controls.Add(this.panel4);
            this.btn_log_in.Location = new System.Drawing.Point(28, 186);
            this.btn_log_in.Name = "btn_log_in";
            this.btn_log_in.Size = new System.Drawing.Size(100, 46);
            this.btn_log_in.TabIndex = 7;
            this.btn_log_in.Click += new System.EventHandler(this.btn_log_in_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(43, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_log_in_Click);
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.Controls.Add(this.button2);
            this.btn_sign_up.Controls.Add(this.panel5);
            this.btn_sign_up.Location = new System.Drawing.Point(181, 186);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(100, 46);
            this.btn_sign_up.TabIndex = 8;
            this.btn_sign_up.Click += new System.EventHandler(this.btn_sign_up_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(43, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_sign_up_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.btn_sign_up);
            this.panel6.Controls.Add(this.txt_tai_khoan);
            this.panel6.Controls.Add(this.btn_log_in);
            this.panel6.Controls.Add(this.txt_mat_khau);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Location = new System.Drawing.Point(151, 76);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(447, 266);
            this.panel6.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(323, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 46);
            this.panel3.TabIndex = 9;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(43, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 46);
            this.button3.TabIndex = 1;
            this.button3.Text = "Forgot Pass";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::BTLON.Properties.Resources.icons8_forgot_password_64;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(43, 46);
            this.panel7.TabIndex = 0;
            this.panel7.Click += new System.EventHandler(this.panel3_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BTLON.Properties.Resources.icons8_account_64;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(101, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 36);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::BTLON.Properties.Resources.icons8_add_user_male_64;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(43, 46);
            this.panel5.TabIndex = 0;
            this.panel5.Click += new System.EventHandler(this.btn_sign_up_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::BTLON.Properties.Resources.icons8_enter_64;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(43, 46);
            this.panel4.TabIndex = 0;
            this.panel4.Click += new System.EventHandler(this.btn_log_in_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BTLON.Properties.Resources.icons8_password_key_64;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(101, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(46, 36);
            this.panel2.TabIndex = 6;
            // 
            // Đăng_Nhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(750, 402);
            this.Controls.Add(this.panel6);
            this.Name = "Đăng_Nhập";
            this.Text = "Đăng_Nhập";
            this.Load += new System.EventHandler(this.Đăng_Nhập_Load);
            this.btn_log_in.ResumeLayout(false);
            this.btn_sign_up.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_tai_khoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_mat_khau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel btn_log_in;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel btn_sign_up;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel7;
    }
}