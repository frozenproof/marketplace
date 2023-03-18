
namespace BTLON
{
    partial class SQL_Command_Testing_Pop_Up
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
            this.Câu_lệnh_sql = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table_SQL)).BeginInit();
            this.SuspendLayout();
            // 
            // Table_SQL
            // 
            this.Table_SQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_SQL.Location = new System.Drawing.Point(0, 28);
            this.Table_SQL.Name = "Table_SQL";
            this.Table_SQL.Size = new System.Drawing.Size(799, 385);
            this.Table_SQL.TabIndex = 0;
            // 
            // Câu_lệnh_sql
            // 
            this.Câu_lệnh_sql.Location = new System.Drawing.Point(12, 2);
            this.Câu_lệnh_sql.Name = "Câu_lệnh_sql";
            this.Câu_lệnh_sql.Size = new System.Drawing.Size(776, 20);
            this.Câu_lệnh_sql.TabIndex = 1;
            // 
            // SQL_Command_Testing_Pop_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Câu_lệnh_sql);
            this.Controls.Add(this.Table_SQL);
            this.Name = "SQL_Command_Testing_Pop_Up";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SQL_Command_Testing_Pop_Up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table_SQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table_SQL;
        public System.Windows.Forms.TextBox Câu_lệnh_sql;
    }
}