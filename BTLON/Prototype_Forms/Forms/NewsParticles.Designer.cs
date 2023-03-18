
namespace BTLON.Prototype_Forms.Forms
{
    partial class NewsParticles
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
            this.news = new System.Windows.Forms.WebBrowser();
            this.panel3 = new System.Windows.Forms.Panel();
            this.forward_web = new System.Windows.Forms.Button();
            this.reload_web = new System.Windows.Forms.Button();
            this.back_web = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // news
            // 
            this.news.Dock = System.Windows.Forms.DockStyle.Fill;
            this.news.Location = new System.Drawing.Point(0, 0);
            this.news.MinimumSize = new System.Drawing.Size(20, 20);
            this.news.Name = "news";
            this.news.ScriptErrorsSuppressed = true;
            this.news.Size = new System.Drawing.Size(800, 450);
            this.news.TabIndex = 3;
            this.news.Url = new System.Uri("https://google.com", System.UriKind.Absolute);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::BTLON.Properties.Resources.icons8_more_64;
            this.panel3.Controls.Add(this.forward_web);
            this.panel3.Controls.Add(this.reload_web);
            this.panel3.Controls.Add(this.back_web);
            this.panel3.Location = new System.Drawing.Point(607, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 63);
            this.panel3.TabIndex = 17;
            // 
            // forward_web
            // 
            this.forward_web.BackgroundImage = global::BTLON.Properties.Resources.icons8_chevron_right_64;
            this.forward_web.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forward_web.Dock = System.Windows.Forms.DockStyle.Left;
            this.forward_web.FlatAppearance.BorderSize = 0;
            this.forward_web.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forward_web.Location = new System.Drawing.Point(86, 0);
            this.forward_web.Name = "forward_web";
            this.forward_web.Size = new System.Drawing.Size(43, 63);
            this.forward_web.TabIndex = 3;
            this.forward_web.UseVisualStyleBackColor = true;
            this.forward_web.Click += new System.EventHandler(this.forward_web_Click);
            // 
            // reload_web
            // 
            this.reload_web.BackgroundImage = global::BTLON.Properties.Resources.icons8_synchronize_64;
            this.reload_web.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reload_web.Dock = System.Windows.Forms.DockStyle.Left;
            this.reload_web.FlatAppearance.BorderSize = 0;
            this.reload_web.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reload_web.Location = new System.Drawing.Point(43, 0);
            this.reload_web.Name = "reload_web";
            this.reload_web.Size = new System.Drawing.Size(43, 63);
            this.reload_web.TabIndex = 2;
            this.reload_web.UseVisualStyleBackColor = true;
            this.reload_web.Click += new System.EventHandler(this.reload_web_Click);
            // 
            // back_web
            // 
            this.back_web.BackgroundImage = global::BTLON.Properties.Resources.icons8_chevron_left_64;
            this.back_web.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_web.Dock = System.Windows.Forms.DockStyle.Left;
            this.back_web.FlatAppearance.BorderSize = 0;
            this.back_web.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_web.Location = new System.Drawing.Point(0, 0);
            this.back_web.Name = "back_web";
            this.back_web.Size = new System.Drawing.Size(43, 63);
            this.back_web.TabIndex = 0;
            this.back_web.UseVisualStyleBackColor = true;
            this.back_web.Click += new System.EventHandler(this.back_web_Click);
            // 
            // NewsParticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.news);
            this.Name = "NewsParticles";
            this.Text = "NewsParticles";
            this.Load += new System.EventHandler(this.NewsParticles_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser news;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button forward_web;
        private System.Windows.Forms.Button reload_web;
        private System.Windows.Forms.Button back_web;
    }
}