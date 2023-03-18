using System;
using System.Data;
using System.Windows.Forms;

namespace BTLON.Forms
{
    public partial class Hiển_Thị_Các_Công_Ty : Form
    {
        External_SQL_Data_Bridge công_ty_sql_bridge = new External_SQL_Data_Bridge();
        public Hiển_Thị_Các_Công_Ty()
        {
            InitializeComponent();
        }
        public string cập_nhật_bảng_nhìn_người_dùng = "select [Mã kinh doanh niêm yết],[Số cổ phần giao dịch],[Giá hiện tại],[Giá tham chiếu],[Giá trần],[Giá sàn],[Giá mua tốt nhất],[Số lượng cần mua],[Giá bán tốt nhất],[Số lượng cần bán],[Tổng số cổ phần] from sangiaodich.dbo.congty";
        public string lấy_số_tiền = "select [Số tiền] from sangiaodich.dbo.nguoidung";
        private void Hiển_Thị_Các_Công_Ty_Load(object sender, EventArgs e)
        {
            cập_nhật_dữ_liệu_bảng();
        }
        private void cập_nhật_dữ_liệu_bảng()
        {
            table_sql_công_ty.DataSource = công_ty_sql_bridge.Fill_Data_Table(cập_nhật_bảng_nhìn_người_dùng);
        }
        private string lấy_số_tiền_dư()
        {
            DataTable tiền = new DataTable();
            tiền = công_ty_sql_bridge.Fill_Data_Table(lấy_số_tiền);
            return tiền.Rows[0].Field<long>(0).ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTimeText.Text = DateTime.Now.ToLongTimeString();
        }

        private void Giao_dịch_Click(object sender, EventArgs e)
        {
            if (Kho.giao_Dịch.IsDisposed)
                Kho.giao_Dịch = new Giao_dịch();
            Kho.giao_Dịch.Show();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (Kho.log_in.IsDisposed)
                    Kho.log_in = new Log_In();
                Kho.log_in.Show();
                Kho.ten_kh = "";
                this.Close();
            }
        }

        private void Sửa_thông_tin_Click(object sender, EventArgs e)
        {
            if (Kho.Thay_Đổi_Thông_Tin.IsDisposed)
                Kho.Thay_Đổi_Thông_Tin = new Thay_đổi_thông_tin();
            Kho.Thay_Đổi_Thông_Tin.Show();
            this.Close();
        }

        private void Xem_tài_khoản_Click(object sender, EventArgs e)
        {
            if (Kho.hiện.IsDisposed)
                Kho.hiện = new Khung_thông_báo();
            Kho.hiện.đặt_tên("Số dư", lấy_số_tiền_dư());
            Kho.hiện.block();
            Kho.hiện.Show();
        }

        private void Lịch_sử_Click(object sender, EventArgs e)
        {

        }

        private void thông_tin_tài_khoản1_Load(object sender, EventArgs e)
        {

        }

        private void DateTimeText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
