
namespace BTLON
{
    partial class SQL_Command_Testing
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
            this.Table_SQL = new System.Windows.Forms.DataGridView();
            this.Câu_Lệnh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table_SQL)).BeginInit();
            this.SuspendLayout();
            // 
            // Table_SQL
            // 
            this.Table_SQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_SQL.Location = new System.Drawing.Point(2, 53);
            this.Table_SQL.Name = "Table_SQL";
            this.Table_SQL.Size = new System.Drawing.Size(908, 312);
            this.Table_SQL.TabIndex = 0;
            // 
            // Câu_Lệnh
            // 
            this.Câu_Lệnh.Location = new System.Drawing.Point(2, 16);
            this.Câu_Lệnh.Name = "Câu_Lệnh";
            this.Câu_Lệnh.Size = new System.Drawing.Size(907, 20);
            this.Câu_Lệnh.TabIndex = 1;
            // 
            // SQL_Command_Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 365);
            this.Controls.Add(this.Câu_Lệnh);
            this.Controls.Add(this.Table_SQL);
            this.Name = "SQL_Command_Testing";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SQL_Command_Testing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table_SQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table_SQL;
        private System.Windows.Forms.TextBox Câu_Lệnh;
    }
}