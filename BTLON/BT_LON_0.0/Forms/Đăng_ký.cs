using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BTLON.Forms
{
    public partial class Đăng_ký : Form
    {
        External_SQL_Data_Bridge đăng_kí_external_SQL_Data_Bridge = new External_SQL_Data_Bridge();
        public Đăng_ký()
        {
            InitializeComponent();
        }

        private void Quay_Lại_Log_in_Click(object sender, EventArgs e)
        {
            if(Kho.log_in.IsDisposed)
                Kho.log_in = new Log_In();
                Kho.log_in.Show();      
                Kho.đăng_ký.Close();
        }

        private void Đăng_ký_Load(object sender, EventArgs e)
        {
            Giới_tính.Items.Add("Nam");
            Giới_tính.Items.Add("Nữ");
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
            Kho.màn_Hình_Tổng.Show();
        }

        private void xác_nhận_đăng_kí_Click(object sender, EventArgs e)
        {
            if (kiểm_tra_thông_tin_điền())
            {
                MessageBox.Show("Tài khoản hợp lệ, đang cập nhật dữ liệu.");
                nhập_thông_tin_vào_bảng_người_dùng();
                MessageBox.Show("Cập nhật dữ liệu hoàn tất.");
                return;
            }      
        }

        private void nhập_thông_tin_vào_bảng_người_dùng()
        {
            string câu_lệnh_điền_bảng_người_dùng = "insert into sangiaodich.dbo.nguoidung values('"+Họ_tên.Text + "',N'" + Số_điện_thoại.Text + "',N'" + Địa_chỉ.Text + "',N'"+ CMND.Text+ "',N'09-09-2020',N'Hà Nội',N'900000',N'0',N'" + Tên_tài_khoản.Text+ "',N'"+ Mật_khẩu.Text+ "',N'" + Giới_tính.SelectedItem.ToString()+ "')";
            //SQL_Command_Testing_Pop_Up temp = new SQL_Command_Testing_Pop_Up();
            //temp.Câu_lệnh_sql.Text = câu_lệnh_điền_bảng_người_dùng;
            //temp.Show();
            //insert into sangiaodich.dbo.nguoidung values('00000004',N'gà con',N'0999000004',N'Hà nội',N'92348348924',N'09-09-2020',N'Hà Nội',N'93045934',N'0',N'meo1','123456',N'Nam')
            đăng_kí_external_SQL_Data_Bridge.chạy_lệnh_SQL(câu_lệnh_điền_bảng_người_dùng);
            MessageBox.Show("Đăng kí thành công.");
            return;
        }

        private bool kiểm_tra_thông_tin_điền()
        {
            if(kiểm_tra_trống())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return false;
            }
            DataTable rows_count = đăng_kí_external_SQL_Data_Bridge.Fill_Data_Table("SELECT Count(*)  from Sangiaodich.dbo.nguoidung");
            DataTable Log_In_Table = đăng_kí_external_SQL_Data_Bridge.Fill_Data_Table("select [Tên tài khoản],[Mật khẩu] from Sangiaodich.dbo.nguoidung");
          
            int rows = rows_count.Rows[0].Field<int>(0);
            int Số_dòng = 0;
            while (Số_dòng < rows)
            {
                if (Kiểm_tra_tồn_tại_tên_tài_khoản(Log_In_Table, Số_dòng))
                {
                    break;
                }
                Số_dòng++;
            }
            if (Số_dòng >= rows)
            {
                if(Kiểm_tra_mật_khẩu())
                {
                    return true;
                }
            }
            return false;
        }

        private bool kiểm_tra_trống()
        {
            foreach(Control control in panel1.Controls)
            {
                if(control.Text=="")
                {
                    return true;
                }
            }
            return false;
        }

        private bool Kiểm_tra_tồn_tại_tên_tài_khoản(DataTable log_In_Table, int Số_dòng)
        {
            if (log_In_Table.Rows[Số_dòng].Field<string>(0).ToString().Trim() == Tên_tài_khoản.Text.Trim())
            {
                MessageBox.Show("Tên tài khoản tồn tại. Vui lòng đổi tên tài khoản.");
                return true;
            }
            return false;
        }
        private bool Kiểm_tra_mật_khẩu()
        {
            if(Mật_khẩu.Text.Trim().Equals(Lại_mật_khẩu.Text.Trim()))
            {
                return true;
            }
            return false;
        }

  
        private void Kiểm_tra_gõ_số(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i = 0;
            foreach (Control control in panel1.Controls)
            {
                if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    i++;
                    MessageBox.Show(i.ToString());
                    control.Text = "9000000";
                }
            }
            return;

        }

        private void Giới_tính_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Giới_tính.SelectedItem.ToString());
        }
    }
}
