
namespace BTLON.Prototype_Forms.Forms
{
    partial class Account
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
            this.main_flow_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_stno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dia_chi = new System.Windows.Forms.TextBox();
            this.txt_gt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ten_tk = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.lbl_confirm = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Label();
            this.btn_change_password = new System.Windows.Forms.Label();
            this.txt_so_du = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_avatar = new System.Windows.Forms.Label();
            this.pt_avatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ho_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sum_table = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ten_bang = new System.Windows.Forms.ComboBox();
            this.btn_tong_hop = new System.Windows.Forms.Button();
            this.main_flow_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_avatar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sum_table)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_flow_panel
            // 
            this.main_flow_panel.AutoScroll = true;
            this.main_flow_panel.BackColor = System.Drawing.Color.Black;
            this.main_flow_panel.Controls.Add(this.panel1);
            this.main_flow_panel.Controls.Add(this.panel2);
            this.main_flow_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_flow_panel.Location = new System.Drawing.Point(0, 0);
            this.main_flow_panel.Name = "main_flow_panel";
            this.main_flow_panel.Size = new System.Drawing.Size(816, 749);
            this.main_flow_panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_stno);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_dia_chi);
            this.panel1.Controls.Add(this.txt_gt);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_ten_tk);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_sdt);
            this.panel1.Controls.Add(this.lbl_confirm);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_change_password);
            this.panel1.Controls.Add(this.txt_so_du);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_avatar);
            this.panel1.Controls.Add(this.pt_avatar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_ho_ten);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 450);
            this.panel1.TabIndex = 15;
            // 
            // txt_stno
            // 
            this.txt_stno.Location = new System.Drawing.Point(123, 423);
            this.txt_stno.Name = "txt_stno";
            this.txt_stno.ReadOnly = true;
            this.txt_stno.Size = new System.Drawing.Size(209, 20);
            this.txt_stno.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số tiền nợ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Địa chỉ";
            // 
            // txt_dia_chi
            // 
            this.txt_dia_chi.Location = new System.Drawing.Point(122, 262);
            this.txt_dia_chi.Name = "txt_dia_chi";
            this.txt_dia_chi.Size = new System.Drawing.Size(212, 20);
            this.txt_dia_chi.TabIndex = 20;
            // 
            // txt_gt
            // 
            this.txt_gt.Location = new System.Drawing.Point(123, 350);
            this.txt_gt.Name = "txt_gt";
            this.txt_gt.Size = new System.Drawing.Size(98, 20);
            this.txt_gt.TabIndex = 18;
            this.txt_gt.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(19, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tên tài khoản";
            // 
            // txt_ten_tk
            // 
            this.txt_ten_tk.Location = new System.Drawing.Point(123, 180);
            this.txt_ten_tk.Name = "txt_ten_tk";
            this.txt_ten_tk.Size = new System.Drawing.Size(212, 20);
            this.txt_ten_tk.TabIndex = 16;
            this.txt_ten_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Số điện thoại";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(123, 306);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(212, 20);
            this.txt_sdt.TabIndex = 14;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.AutoSize = true;
            this.lbl_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_confirm.Location = new System.Drawing.Point(162, 119);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(94, 13);
            this.lbl_confirm.TabIndex = 12;
            this.lbl_confirm.Text = "Xác nhận thay đổi";
            this.lbl_confirm.Click += new System.EventHandler(this.lbl_confirm_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_delete.Location = new System.Drawing.Point(162, 90);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(73, 13);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Xóa tài khoản";
            // 
            // btn_change_password
            // 
            this.btn_change_password.AutoSize = true;
            this.btn_change_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_change_password.Location = new System.Drawing.Point(162, 55);
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.Size = new System.Drawing.Size(96, 13);
            this.btn_change_password.TabIndex = 8;
            this.btn_change_password.Text = "Thay đổi mật khẩu";
            this.btn_change_password.Click += new System.EventHandler(this.btn_change_password_Click);
            // 
            // txt_so_du
            // 
            this.txt_so_du.Location = new System.Drawing.Point(123, 396);
            this.txt_so_du.Name = "txt_so_du";
            this.txt_so_du.ReadOnly = true;
            this.txt_so_du.Size = new System.Drawing.Size(209, 20);
            this.txt_so_du.TabIndex = 10;
            this.txt_so_du.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số dư";
            // 
            // btn_avatar
            // 
            this.btn_avatar.AutoSize = true;
            this.btn_avatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_avatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_avatar.Location = new System.Drawing.Point(162, 25);
            this.btn_avatar.Name = "btn_avatar";
            this.btn_avatar.Size = new System.Drawing.Size(82, 13);
            this.btn_avatar.TabIndex = 5;
            this.btn_avatar.Text = "Thay đổi avatar";
            this.btn_avatar.Click += new System.EventHandler(this.btn_avatar_Click);
            // 
            // pt_avatar
            // 
            this.pt_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pt_avatar.Location = new System.Drawing.Point(25, 12);
            this.pt_avatar.Name = "pt_avatar";
            this.pt_avatar.Size = new System.Drawing.Size(105, 140);
            this.pt_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pt_avatar.TabIndex = 4;
            this.pt_avatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người dùng";
            // 
            // txt_ho_ten
            // 
            this.txt_ho_ten.Location = new System.Drawing.Point(123, 220);
            this.txt_ho_ten.Name = "txt_ho_ten";
            this.txt_ho_ten.Size = new System.Drawing.Size(212, 20);
            this.txt_ho_ten.TabIndex = 1;
            this.txt_ho_ten.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giới tính";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Sum_table);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(376, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 450);
            this.panel2.TabIndex = 16;
            // 
            // Sum_table
            // 
            this.Sum_table.AllowUserToAddRows = false;
            this.Sum_table.AllowUserToDeleteRows = false;
            this.Sum_table.AllowUserToResizeRows = false;
            this.Sum_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sum_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sum_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Sum_table.Location = new System.Drawing.Point(0, 50);
            this.Sum_table.Name = "Sum_table";
            this.Sum_table.ReadOnly = true;
            this.Sum_table.Size = new System.Drawing.Size(428, 400);
            this.Sum_table.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ten_bang);
            this.panel4.Controls.Add(this.btn_tong_hop);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 50);
            this.panel4.TabIndex = 0;
            // 
            // ten_bang
            // 
            this.ten_bang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ten_bang.FormattingEnabled = true;
            this.ten_bang.Items.AddRange(new object[] {
            "Chứng Khoán",
            "Chuyển Tiền"});
            this.ten_bang.Location = new System.Drawing.Point(176, 16);
            this.ten_bang.Name = "ten_bang";
            this.ten_bang.Size = new System.Drawing.Size(114, 21);
            this.ten_bang.TabIndex = 1;
            this.ten_bang.SelectedIndexChanged += new System.EventHandler(this.ten_bang_SelectedIndexChanged);
            // 
            // btn_tong_hop
            // 
            this.btn_tong_hop.BackColor = System.Drawing.Color.White;
            this.btn_tong_hop.Location = new System.Drawing.Point(24, 14);
            this.btn_tong_hop.Name = "btn_tong_hop";
            this.btn_tong_hop.Size = new System.Drawing.Size(84, 24);
            this.btn_tong_hop.TabIndex = 0;
            this.btn_tong_hop.Text = "In tổng hợp";
            this.btn_tong_hop.UseVisualStyleBackColor = false;
            this.btn_tong_hop.Click += new System.EventHandler(this.btn_tong_hop_Click1);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(816, 749);
            this.Controls.Add(this.main_flow_panel);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.main_flow_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_avatar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sum_table)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel main_flow_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_confirm;
        private System.Windows.Forms.Label btn_delete;
        private System.Windows.Forms.Label btn_change_password;
        private System.Windows.Forms.TextBox txt_so_du;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btn_avatar;
        private System.Windows.Forms.PictureBox pt_avatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ho_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_ten_tk;
        private System.Windows.Forms.TextBox txt_gt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dia_chi;
        private System.Windows.Forms.TextBox txt_stno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView Sum_table;
        private System.Windows.Forms.Button btn_tong_hop;
        private System.Windows.Forms.ComboBox ten_bang;
    }
}