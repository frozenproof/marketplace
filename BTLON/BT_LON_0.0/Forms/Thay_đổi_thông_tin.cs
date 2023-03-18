using System;
using System.Data;
using System.Windows.Forms;

namespace BTLON.Forms
{
    public partial class Thay_đổi_thông_tin : Form
    {
        public static int mật_khẩu_đổi = 0;
        External_SQL_Data_Bridge thay_đổi_External_SQL_Data_Bridge = new External_SQL_Data_Bridge();
        public Thay_đổi_thông_tin()
        {
            InitializeComponent();
        }

        private void Quay_lại_giao_dịch_Click(object sender, EventArgs e)
        {
            Kho.Thay_Đổi_Thông_Tin.Close();
            if (Kho.hiển_Thị_Các_Công_Ty.IsDisposed)
                Kho.hiển_Thị_Các_Công_Ty = new Hiển_Thị_Các_Công_Ty();
            Kho.hiển_Thị_Các_Công_Ty.Show();
        }

        private void xác_nhận_thay_đổi_Click(object sender, EventArgs e)
        {
            string thay_đổi_thông_tin = "";
            if (mật_khẩu_đổi != 0)
                thay_đổi_thông_tin = "update SanGiaoDich.dbo.NGUOIDUNG set [Tên người dùng]=N'" + Tên_tài_khoản.Text + "' ,  [Mật khẩu] = N'" + Mật_khẩu.Text + "' where [Tên tài khoản]= '" + Kho.ten_kh + "'";
            else
                thay_đổi_thông_tin = "update SanGiaoDich.dbo.NGUOIDUNG set [Tên người dùng]=N'" + Tên_tài_khoản.Text + "' where [Tên tài khoản]= '" + Kho.ten_kh + "'";
            //Just_text just_text = new Just_text();
            //just_text.đặt_tên("Đổi", thay_đổi_thông_tin);
            //just_text.Show();
            thay_đổi_External_SQL_Data_Bridge.chạy_lệnh_SQL(thay_đổi_thông_tin);
            Quay_lại_giao_dịch_Click(sender, e);
            mật_khẩu_đổi = 0;
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo,
     MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
            Kho.hiển_Thị_Các_Công_Ty.Close();
            if (Kho.log_in.IsDisposed)
                Kho.log_in = new Log_In();
            Kho.log_in.Show();
        }

        private void Thay_đổi_thông_tin_Load(object sender, EventArgs e)
        {
            DataTable bảng = lấy_thông_tin_từ_bảng();
            Tên_tài_khoản.Text = bảng.Rows[0].Field<string>(8);
            Mật_khẩu.Text = "Không đổi";
            Lại_mật_khẩu.Text = "Không đổi";
            Họ_tên.Text = bảng.Rows[0].Field<string>(0);
            CMND.Text = bảng.Rows[0].Field<string>(3).ToString();
            Số_điện_thoại.Text = bảng.Rows[0].Field<string>(1).ToString();
            Địa_chỉ.Text = bảng.Rows[0].Field<string>(2).ToString();
            Giới_tính.Items.Add("Nam");
            Giới_tính.Items.Add("Nữ");
            if (bảng.Rows[0].Field<string>(10).ToString().Trim() == "Nam")
            {
                Giới_tính.SelectedIndex = 0;
            }
            else
            {
                Giới_tính.SelectedIndex = 1;
            }
        }

        private DataTable lấy_thông_tin_từ_bảng()
        {
            string câu_lệnh_lấy_thông_tin_người_dùng_dựa_trên_tên = "select * from sangiaodich.dbo.nguoidung where [Tên tài khoản] = N'" + Kho.ten_kh + "'";
            DataTable dataTable = thay_đổi_External_SQL_Data_Bridge.Fill_Data_Table(câu_lệnh_lấy_thông_tin_người_dùng_dựa_trên_tên);
            return dataTable;
        }

        private void Xóa_tài_khoản_Click(object sender, EventArgs e)
        {
            string xóa_tài_khoản = "Delete From sangiaodich.dbo.nguoidung Where [Tên tài khoản] =N'" + Kho.ten_kh + "'"; ;
            Kho.ten_kh = "";
            MessageBox.Show("Xóa tài khoản thành công");
            thay_đổi_External_SQL_Data_Bridge.chạy_lệnh_SQL(xóa_tài_khoản);
            if (Kho.log_in.IsDisposed)
                Kho.log_in = new Log_In();
            if (!Kho.hiển_Thị_Các_Công_Ty.IsDisposed)
            {
                Kho.hiển_Thị_Các_Công_Ty.Close();
            }
            Kho.log_in.Show();
            Kho.Thay_Đổi_Thông_Tin.Close();
        }

        private void Mật_khẩu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mật_khẩu_đổi == 0)
            {
                Mật_khẩu.Text = "";
                Lại_mật_khẩu.Text = "";
                Lại_mật_khẩu.Enabled = true;
            }
            mật_khẩu_đổi = 1;
        }

        private void Mật_khẩu_TextChanged(object sender, EventArgs e)
        {
            Lại_mật_khẩu.Text = "";
        }
    }
}
