
namespace BTLON.Prototype_Forms.ChildForms
{
    partial class Forgot_Password
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_tai_khoan = new System.Windows.Forms.TextBox();
            this.btn_log_in = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_mat_khau = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.btn_log_in.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.txt_tai_khoan);
            this.panel6.Controls.Add(this.btn_log_in);
            this.panel6.Controls.Add(this.txt_mat_khau);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Location = new System.Drawing.Point(177, 92);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(447, 266);
            this.panel6.TabIndex = 10;
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
            // txt_tai_khoan
            // 
            this.txt_tai_khoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tai_khoan.Location = new System.Drawing.Point(153, 36);
            this.txt_tai_khoan.Name = "txt_tai_khoan";
            this.txt_tai_khoan.Size = new System.Drawing.Size(192, 31);
            this.txt_tai_khoan.TabIndex = 2;
            this.txt_tai_khoan.Text = "meo";
            // 
            // btn_log_in
            // 
            this.btn_log_in.Controls.Add(this.button1);
            this.btn_log_in.Controls.Add(this.panel4);
            this.btn_log_in.Location = new System.Drawing.Point(176, 183);
            this.btn_log_in.Name = "btn_log_in";
            this.btn_log_in.Size = new System.Drawing.Size(100, 46);
            this.btn_log_in.TabIndex = 7;
            this.btn_log_in.Click += new System.EventHandler(this.button1_Click);
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
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.panel4.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_mat_khau
            // 
            this.txt_mat_khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat_khau.Location = new System.Drawing.Point(153, 99);
            this.txt_mat_khau.Name = "txt_mat_khau";
            this.txt_mat_khau.ReadOnly = true;
            this.txt_mat_khau.Size = new System.Drawing.Size(192, 31);
            this.txt_mat_khau.TabIndex = 6;
            this.txt_mat_khau.Text = "123456";
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
            // Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Name = "Forgot_Password";
            this.Text = "Forgot_Password";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.btn_log_in.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_tai_khoan;
        private System.Windows.Forms.Panel btn_log_in;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_mat_khau;
        private System.Windows.Forms.Panel panel2;
    }
}