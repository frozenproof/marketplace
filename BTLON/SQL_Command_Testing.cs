using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON
{
    public partial class SQL_Command_Testing : Form
    {
        External_SQL_Data_Bridge bridge = new External_SQL_Data_Bridge();
        public SQL_Command_Testing()
        {
            InitializeComponent();
        }

        private void SQL_Command_Testing_Load(object sender, EventArgs e)
        {
            DataTable Temporary_Data_Table = new DataTable();
            DataTable rows_count = new DataTable();
            DataTable columns_count = new DataTable();
            //Temporary_Data_Table = bridge.Fill_Data_Table("Select [Tên tài khoản],[Mật khẩu] from nguoidung");
            Temporary_Data_Table = bridge.Fill_Data_Table("select [Tên tài khoản],[Mật khẩu] from sangiaodich.dbo.nguoidung");
            rows_count = bridge.Fill_Data_Table("SELECT Count(*)  from Sangiaodich.dbo.nguoidung");
            columns_count = bridge.Fill_Data_Table("SELECT COUNT(COLUMN_NAME) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_CATALOG = 'SanGiaodich' AND TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'nguoidung'   ");
            //            SELECT COUNT(COLUMN_NAME)
            //FROM INFORMATION_SCHEMA.COLUMNS
            //WHERE
            //
            int rows =rows_count.Rows[0].Field<int>(0);
            int columns = rows_count.Rows[0].Field<int>(0); 
            Table_SQL.DataSource = Temporary_Data_Table;
            for (int i = 0; i < rows; i++)
                //for (int j = 0; j < columns; j++)
                    MessageBox.Show(Temporary_Data_Table.Rows[i].Field<string>(0).ToString());
        }
    }
}
