
namespace BTLON.Prototype_Forms.ChildForms.Giao_dich.Tien
{
    partial class RutTien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_nạp_tiền = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_so_du = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_reset_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tien = new System.Windows.Forms.TextBox();
            this.txt_phi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.btn_nạp_tiền.SuspendLayout();
            this.btn_clear.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_nạp_tiền);
            this.panel1.Controls.Add(this.txt_so_du);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_tien);
            this.panel1.Controls.Add(this.txt_phi);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(159, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 280);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::BTLON.Properties.Resources.icons8_done_64__1_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(55, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(38, 35);
            this.panel4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(111, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số dư";
            // 
            // btn_nạp_tiền
            // 
            this.btn_nạp_tiền.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_nạp_tiền.Controls.Add(this.button1);
            this.btn_nạp_tiền.Controls.Add(this.panel5);
            this.btn_nạp_tiền.Location = new System.Drawing.Point(274, 192);
            this.btn_nạp_tiền.Name = "btn_nạp_tiền";
            this.btn_nạp_tiền.Size = new System.Drawing.Size(100, 46);
            this.btn_nạp_tiền.TabIndex = 9;
            this.btn_nạp_tiền.Click += new System.EventHandler(this.btn_rut_tien_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(43, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rút tiền";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_rut_tien_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BackgroundImage = global::BTLON.Properties.Resources.icons8_in_progress_64;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(43, 46);
            this.panel5.TabIndex = 0;
            this.panel5.Click += new System.EventHandler(this.btn_rut_tien_Click);
            // 
            // txt_so_du
            // 
            this.txt_so_du.BackColor = System.Drawing.Color.White;
            this.txt_so_du.Location = new System.Drawing.Point(163, 24);
            this.txt_so_du.Name = "txt_so_du";
            this.txt_so_du.ReadOnly = true;
            this.txt_so_du.Size = new System.Drawing.Size(268, 20);
            this.txt_so_du.TabIndex = 8;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_clear.Controls.Add(this.btn_reset);
            this.btn_clear.Controls.Add(this.btn_reset_panel);
            this.btn_clear.Location = new System.Drawing.Point(121, 192);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 46);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Black;
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(43, 0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(57, 46);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_reset_panel
            // 
            this.btn_reset_panel.BackColor = System.Drawing.Color.Black;
            this.btn_reset_panel.BackgroundImage = global::BTLON.Properties.Resources.icons8_time_machine_64;
            this.btn_reset_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reset_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_reset_panel.Location = new System.Drawing.Point(0, 0);
            this.btn_reset_panel.Name = "btn_reset_panel";
            this.btn_reset_panel.Size = new System.Drawing.Size(43, 46);
            this.btn_reset_panel.TabIndex = 0;
            this.btn_reset_panel.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::BTLON.Properties.Resources.icons8_add_dollar_642;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(55, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(38, 35);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BTLON.Properties.Resources.icons8_tax_64;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(55, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 35);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tiền phí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tiền";
            // 
            // txt_tien
            // 
            this.txt_tien.BackColor = System.Drawing.Color.White;
            this.txt_tien.Location = new System.Drawing.Point(163, 76);
            this.txt_tien.Name = "txt_tien";
            this.txt_tien.Size = new System.Drawing.Size(268, 20);
            this.txt_tien.TabIndex = 1;
            this.txt_tien.TextChanged += new System.EventHandler(this.txt_tien_TextChanged);
            this.txt_tien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tien_KeyPress);
            // 
            // txt_phi
            // 
            this.txt_phi.BackColor = System.Drawing.Color.White;
            this.txt_phi.Location = new System.Drawing.Point(163, 123);
            this.txt_phi.Name = "txt_phi";
            this.txt_phi.ReadOnly = true;
            this.txt_phi.Size = new System.Drawing.Size(268, 20);
            this.txt_phi.TabIndex = 2;
            // 
            // RutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "RutTien";
            this.Text = "RutTien";
            this.Load += new System.EventHandler(this.RutTien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btn_nạp_tiền.ResumeLayout(false);
            this.btn_clear.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btn_nạp_tiền;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel btn_clear;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel btn_reset_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tien;
        private System.Windows.Forms.TextBox txt_phi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_so_du;
    }
}