
namespace BTLON.Prototype_Forms.ChildForms
{
    partial class Default_Home_Screen
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
            this.components = new System.ComponentModel.Container();
            this.Panel_time = new System.Windows.Forms.Panel();
            this.label_time = new System.Windows.Forms.Label();
            this.Đồng_hồ = new System.Windows.Forms.Timer(this.components);
            this.Panel_time.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_time
            // 
            this.Panel_time.Controls.Add(this.label_time);
            this.Panel_time.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_time.Location = new System.Drawing.Point(0, 0);
            this.Panel_time.Name = "Panel_time";
            this.Panel_time.Size = new System.Drawing.Size(729, 103);
            this.Panel_time.TabIndex = 0;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(0, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(81, 20);
            this.label_time.TabIndex = 0;
            this.label_time.Text = "label_time";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Đồng_hồ
            // 
            this.Đồng_hồ.Enabled = true;
            this.Đồng_hồ.Interval = 500;
            this.Đồng_hồ.Tick += new System.EventHandler(this.Đồng_hồ_Tick);
            // 
            // Default_Home_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 230);
            this.Controls.Add(this.Panel_time);
            this.Name = "Default_Home_Screen";
            this.Text = "Default_Home_Screen";
            this.Panel_time.ResumeLayout(false);
            this.Panel_time.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_time;
        private System.Windows.Forms.Timer Đồng_hồ;
        private System.Windows.Forms.Label label_time;
    }
}