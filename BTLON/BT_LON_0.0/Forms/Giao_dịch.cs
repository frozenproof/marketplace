using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BTLON.Forms
{
    public partial class Giao_dịch : Form
    {
        External_SQL_Data_Bridge giao_dịch_External_SQL_Data_Bridge = new External_SQL_Data_Bridge();
        public Giao_dịch()
        {
            InitializeComponent();
        }

        private void Quay_lại_giao_dịch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Xác_nhận_giao_dịch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thông tin: " + loại_giao_dịch.SelectedItem.ToString());
            if (kiểm_tra_trống())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            MessageBox.Show("Thông tin: " + loại_giao_dịch.SelectedItem.ToString());
            thực_hiện_giao_dịch(loại_giao_dịch.SelectedItem.ToString().Trim());
            //string điền_bảng_giao_dịch = "insert into sangiaodich.dbo.giaodich values(N'"+địa_chỉ_nhập_tiếp_theo+"',N'"++"')";
            //giao_dịch_External_SQL_Data_Bridge.chạy_lệnh_SQL(điền_bảng_giao_dịch);
        }

        private void thực_hiện_giao_dịch(string lệnh_giao_dịch)
        {
            string lệnh_sql = "";
            switch (lệnh_giao_dịch)
            {
                case "Vay tiền":
                    {
                        lệnh_sql = "update sangiaodich.dbo.nguoidung set[Số tiền còn trong tài khoản] = [Số tiền còn trong tài khoản] +" + long.Parse(Số_tiền_giao_dịch.Text) + " - " + long.Parse(Phí_giao_dịch.Text) + ",[Số tiền nợ] = [Số_tiền_giao_dịch tiền nợ] +'" + long.Parse(Số_tiền_giao_dịch.Text) + "' where[Tên tài khoản] = N'" + Kho.ten_kh + "'";
                        break;
                    }
                case "Nạp tiền":
                    {
                        lệnh_sql = "update sangiaodich.dbo.nguoidung set[Số tiền còn trong tài khoản] = [Số tiền còn trong tài khoản] +" + long.Parse(Số_tiền_giao_dịch.Text) + " - " + long.Parse(Phí_giao_dịch.Text) + "  where[Tên tài khoản] = N'" + Kho.ten_kh + "'";
                        break;
                    }
                case "Rút tiền":
                    {
                        lệnh_sql = "update sangiaodich.dbo.nguoidung set[Số tiền còn trong tài khoản] = [Số tiền còn trong tài khoản] -" + long.Parse(Số_tiền_giao_dịch.Text) + " - " + long.Parse(Phí_giao_dịch.Text) + "  where[Tên tài khoản] = N'" + Kho.ten_kh + "'";
                        break; 
                    }
                case "Bán cổ phiếu":
                    {
                        break;
                    }
                case "Mua cổ phiếu":
                    {
                        break;
                    }
                case null:
                    {
                        MessageBox.Show("Không thể thực hiện giao dịch!");
                        break;
                    }
            }
            try
            {
                giao_dịch_External_SQL_Data_Bridge.chạy_lệnh_SQL(lệnh_sql);
            }
            catch
            {
                MessageBox.Show("Không thể thực hiện giao dịch");
                Khung_thông_báo decoy_sql = new Khung_thông_báo();
                decoy_sql.đặt_tên(lệnh_giao_dịch, lệnh_sql);
                decoy_sql.Show();
                return;
            }
            MessageBox.Show("Thực hiện giao dịch");
        }

        private void Giao_dịch_Load(object sender, EventArgs e)
        {
            loại_giao_dịch.Items.Add("Nạp tiền");
            loại_giao_dịch.Items.Add("Rút tiền");
            loại_giao_dịch.Items.Add("Vay tiền");
            loại_giao_dịch.Items.Add("Mua cổ phiếu");
            loại_giao_dịch.Items.Add("Bán cổ phiếu");
            loại_giao_dịch.SelectedIndex = 0;
        }

        private void form_nhập_bảng(string nhập_bảng)
        {
            DataTable bảng = new DataTable();
            bảng = giao_dịch_External_SQL_Data_Bridge.Fill_Data_Table(nhập_bảng);
            mã_công_ty.DataSource = bảng;
        }

        private bool kiểm_tra_trống()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control.Text == "" && control.GetType().ToString() != "System.Windows.Forms.DataGridView")
                {
                    MessageBox.Show(control.GetType().ToString());
                    return true;
                }
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
        private void mã_công_ty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mã_công_ty_giao_dịch = mã_công_ty.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(mã_công_ty_giao_dịch);
        }

        private void loại_giao_dịch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lấy_bảng = "";
            if (loại_giao_dịch.SelectedItem.ToString() == "Vay tiền")
            {
                lấy_bảng = "select [Số tiền còn trong tài khoản],[Số tiền nợ] from sangiaodich.dbo.nguoidung where [Tên tài khoản]=N'" + Kho.ten_kh + "'";
                lbl_giao_dịch.Text = "Vay tiền";
                số_cổ_phiếu_giao_dịch.Text = "0";
                số_cổ_phiếu_giao_dịch.Enabled = false;
            }
            if (loại_giao_dịch.SelectedItem.ToString() == "Nạp tiền")
            {
                lấy_bảng = "select [Số tiền còn trong tài khoản],[Số tiền nợ] from sangiaodich.dbo.nguoidung where [Tên tài khoản]=N'" + Kho.ten_kh + "'";
                số_cổ_phiếu_giao_dịch.Text = "0";
                lbl_giao_dịch.Text = "Nạp tiền";
                số_cổ_phiếu_giao_dịch.Enabled = false;
            }
            if (loại_giao_dịch.SelectedItem.ToString() == "Rút tiền")
            {
                lấy_bảng = "select [Số tiền còn trong tài khoản],[Số tiền nợ] from sangiaodich.dbo.nguoidung where [Tên tài khoản]=N'" + Kho.ten_kh + "'";
                số_cổ_phiếu_giao_dịch.Text = "0";
                lbl_giao_dịch.Text = "Rút tiền";
                số_cổ_phiếu_giao_dịch.Enabled = false;
            }

            if (loại_giao_dịch.SelectedItem.ToString() == "Mua cổ phiếu")
            {
                lấy_bảng = "select [Mã kinh doanh niêm yết],[Giá hiện tại],[Số cổ phần giao dịch] from sangiaodich.dbo.congty";
                lbl_giao_dịch.Text = "Mua cổ phiếu";
                số_cổ_phiếu_giao_dịch.Enabled = true;
            }
            if (loại_giao_dịch.SelectedItem.ToString() == "Bán cổ phiếu")
            {
                lấy_bảng = "select [Mã kinh doanh niêm yết],[Giá hiện tại] from sangiaodich.dbo.congty";
                lbl_giao_dịch.Text = "Bán cổ phiếu";
                số_cổ_phiếu_giao_dịch.Enabled = true;
            }

            form_nhập_bảng(lấy_bảng);
        }

        private void Số_tiền_giao_dịch_TextChanged(object sender, EventArgs e)
        {
            double tam = long.Parse(Số_tiền_giao_dịch.Text);
            Phí_giao_dịch.Text = (tam * 0.1).ToString();
        }
    }
}
