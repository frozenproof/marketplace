
namespace BTLON.Prototype_Forms.ChildForms.Theo_doi
{
    partial class TheoDoi
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
            this.TableCompany = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TableCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // TableCompany
            // 
            this.TableCompany.BackgroundColor = System.Drawing.Color.Black;
            this.TableCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableCompany.GridColor = System.Drawing.Color.Black;
            this.TableCompany.Location = new System.Drawing.Point(0, 0);
            this.TableCompany.Name = "TableCompany";
            this.TableCompany.Size = new System.Drawing.Size(800, 450);
            this.TableCompany.TabIndex = 1;
            this.TableCompany.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.TableCompany_CellFormatting);
            // 
            // TheoDoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableCompany);
            this.Name = "TheoDoi";
            this.Text = "TheoDoi";
            this.Load += new System.EventHandler(this.TheoDoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView TableCompany;
    }
}