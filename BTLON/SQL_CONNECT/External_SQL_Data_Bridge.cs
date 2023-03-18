using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLON
{
    public class External_SQL_Data_Bridge : Form
    {
        readonly string Connect_Command = "Data Source=SNOWDOLL\\SQLEXPRESS;" +
         /*"Initial Catalog=SanGiaoDich" + */ ";Integrated Security=True";
        SqlConnection Tình_trạng_kết_nối_SQL = null;
        void Open_SQL_Connection()
        {
            Tình_trạng_kết_nối_SQL = new SqlConnection(Connect_Command);
            if (Tình_trạng_kết_nối_SQL.State != ConnectionState.Open)
                try
                {
                    Tình_trạng_kết_nối_SQL.Open();
                }
                catch
                {                   
                    MessageBox.Show("Khong ton tai ket noi");
                    return;
                }
        }
        void Close_SQL_Connection()
        {
            if (Tình_trạng_kết_nối_SQL.State != ConnectionState.Closed)
            {
                Tình_trạng_kết_nối_SQL.Close();
                Tình_trạng_kết_nối_SQL.Dispose();
            }
        }

        public DataTable Fill_Data_Table(string sqlSelect)
        {
            Open_SQL_Connection();
            DataTable sql_Temporary_dataTable = Get_SQL_Table_Content(sqlSelect);
            Close_SQL_Connection();
            return sql_Temporary_dataTable;
        }

        private DataTable Get_SQL_Table_Content(string sqlSelect)
        {
            DataTable sql_Data_Table = new DataTable();
            SqlDataAdapter sql_Data_Pointer = new SqlDataAdapter(sqlSelect, Tình_trạng_kết_nối_SQL);
            try
            {
                sql_Data_Pointer.Fill(sql_Data_Table);
            }
            catch
            {
                MessageBox.Show("Lỗi định dạng hoặc thiếu cột");
            }
            finally
            {
                sql_Data_Pointer.Dispose();
            }
            return sql_Data_Table;
        }

        public void chạy_lệnh_SQL(string sql)
        {
            Open_SQL_Connection();
            SqlCommand Câu_lệnh = new SqlCommand
            {
                Connection = Tình_trạng_kết_nối_SQL,
                CommandText = sql
            };
            Câu_lệnh.ExecuteNonQuery();
            Close_SQL_Connection();
            Câu_lệnh.Dispose();

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // External_SQL_Data_Bridge
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "External_SQL_Data_Bridge";
            this.Load += new System.EventHandler(this.External_SQL_Data_Bridge_Load);
            this.ResumeLayout(false);

        }

        private void External_SQL_Data_Bridge_Load(object sender, System.EventArgs e)
        {

        }
    }
}