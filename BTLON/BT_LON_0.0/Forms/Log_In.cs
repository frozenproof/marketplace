using System;
using System.Data;
using System.Windows.Forms;

namespace BTLON.Forms
{
    public partial class Log_In : Form
    {
        External_SQL_Data_Bridge log_in_external_sql_data_bridge = new External_SQL_Data_Bridge();
        public Log_In()
        {
            InitializeComponent();
        }

        private void Log_In_Load(object sender, EventArgs e)
        {
            TênTàiKhoản.Text = "meo";
            MậtKhẩu.Text = "123456";
        }

        private void ĐăngNhập_Click(object sender, EventArgs e)
        {
            DataTable rows_count = new DataTable();
            DataTable columns_count = new DataTable();
            DataTable Log_In_Table = log_in_external_sql_data_bridge.Fill_Data_Table("select [Tên tài khoản],[Mật khẩu] from Sangiaodich.dbo.nguoidung");
            rows_count = log_in_external_sql_data_bridge.Fill_Data_Table("SELECT Count(*)  from Sangiaodich.dbo.nguoidung");
            columns_count = log_in_external_sql_data_bridge.Fill_Data_Table("SELECT COUNT(COLUMN_NAME) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'sangiaodich.dbo.nguoidung'   ");

            //SQL_Command_Testing_Pop_Up temp = new SQL_Command_Testing_Pop_Up();
            //temp.setTable(Log_In_Table);
            //temp.Show();
            int rows = rows_count.Rows[0].Field<int>(0);
            int columns = columns_count.Rows[0].Field<int>(0);
            int i = 0;
            //MessageBox.Show(sender.ToString());
            //MessageBox.Show(sender.GetType().ToString());
            while (i < rows)
            {
                if (Kiểm_tra_tài_khoản_tồn_tại(Log_In_Table, i))
                {
                    if (kiểm_tra_mật_khẩu(Log_In_Table, i))
                        break;
                }
                i++;
            }
            if (i >= rows)
            {
                MessageBox.Show("Thông tin tài khoản không chính xác");
            }
            return;
        }

        private bool Kiểm_tra_tài_khoản_tồn_tại(DataTable Log_In_Table, int i)
        {
            if (Log_In_Table.Rows[i].Field<string>(0).Trim() == TênTàiKhoản.Text.Trim())
            {
                return true;
            }
            return false;
        }

        private bool kiểm_tra_mật_khẩu(DataTable Log_In_Table, int i)
        {
            if (Log_In_Table.Rows[i].Field<string>(1).Trim() == MậtKhẩu.Text.Trim())
            {
                Kho.ten_kh = Log_In_Table.Rows[i].Field<string>(0).Trim();
                MessageBox.Show("Đăng nhập thành công, Tên tài khoản :" + Kho.ten_kh);
                if (Kho.hiển_Thị_Các_Công_Ty.IsDisposed)
                    Kho.hiển_Thị_Các_Công_Ty = new Hiển_Thị_Các_Công_Ty();
                Kho.hiển_Thị_Các_Công_Ty.Show();
                Kho.log_in.Close();
                return true;
            }
            return false;
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo,
       MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Kho.màn_Hình_Tổng.Close();
            }
            
        }

        private void ĐăngKý_Click(object sender, EventArgs e)
        {
            if (Kho.đăng_ký.IsDisposed)
                Kho.đăng_ký = new Đăng_ký();
            Kho.đăng_ký.Show();
            Kho.log_in.Close();
        }

        private void QuênMậtKhẩu_Click(object sender, EventArgs e)
        {
            if (Kho.quên_Mật_Khẩu.IsDisposed)
                Kho.quên_Mật_Khẩu = new Quên_mật_khẩu();
            Kho.quên_Mật_Khẩu.Show();
            Kho.log_in.Close();

        }
    }
}
