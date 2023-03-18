using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON.Prototype_Forms.ChildForms.Giao_dich.Tien
{
    public partial class ChuyenTien : Form
    {
        public External_SQL_Data_Bridge temp_nap = new External_SQL_Data_Bridge();
        public DataTable tam_table = new DataTable();
        public long sdu = 0;
        string[] ds = { "Tên tài khoản nhận", "Số tiền nhận", "Tổng chi phí" };
        private void ChuyenTien_Load(object sender, EventArgs e)
        {
            DataTable temp_table = new DataTable();
            temp_table = temp_nap.Fill_Data_Table("select [Số dư] from sangiaodich.dbo.nguoidung where [Tên tài khoản]='" + GlobalVariable.ten_kh + "'");
            txt_so_du.Text = temp_table.Rows[0].Field<long>(0).ToString();
            sdu = long.Parse(txt_so_du.Text);
            usersearch.DataSource = temp_nap.Fill_Data_Table("select [Tên tài khoản] from sangiaodich.dbo.nguoidung where  [Tên tài khoản] != '" + GlobalVariable.ten_kh + "'");
            DataTable gd_tam = new DataTable();
            CommonFormFunctions.thêm_cột_vào_bảng(gd_tam, ds);
            tbl_giaodich.DataSource = gd_tam;

            btn_delete.Enabled = false;
            btn_begin.Enabled = false;
            btn_delete_all.Enabled = false;
        }
        public ChuyenTien()
        {
            InitializeComponent();
        }

        private void btn_reset_panel_Click(object sender, EventArgs e)
        {
            txt_tien.Text = "";
            txt_phi.Text = "";
            txt_username.Text = "";
            txt_final.Text = "";
        }

        private void btn_them_click(object sender, EventArgs e)
        {
            sdu = long.Parse(txt_so_du.Text);
            if (string.IsNullOrEmpty(txt_final.Text) || string.IsNullOrEmpty(txt_tien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết");
                return;
            }
            double tong = double.Parse(txt_tien.Text);
            double tien_phi = double.Parse(txt_phi.Text);
            long chuyen_thuc_te = (long)(tong - tien_phi);
            long tinh_thuc_te = (long)(tong + tien_phi);
            if (long.Parse(txt_so_du.Text) < tinh_thuc_te)
            {
                MessageBox.Show("Tài khoản không đủ");
                return;
            }

            DataTable gd = (DataTable)tbl_giaodich.DataSource;
            int current_rows_number = gd.Rows.Count;
            gd.Rows.InsertAt(gd.NewRow(), current_rows_number);
            gd.Rows[current_rows_number][0] = txt_final.Text;
            gd.Rows[current_rows_number][1] = chuyen_thuc_te.ToString();
            gd.Rows[current_rows_number][2] = tinh_thuc_te.ToString();
            sdu = sdu - tinh_thuc_te;
            txt_so_du.Text = sdu.ToString();

            btn_reset_panel_Click(sender, e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int currently_selected = 0;
            tam_table = (DataTable)tbl_giaodich.DataSource;
            currently_selected = tbl_giaodich.CurrentRow.Index;
            try
            {
                long tien_tinh_lai = (long)(double.Parse(tam_table.Rows[currently_selected].Field<string>(2)));
                sdu = long.Parse(txt_so_du.Text);
                sdu += tien_tinh_lai;
                txt_so_du.Text = sdu.ToString();
                tam_table.Rows[currently_selected].Delete();
            }
            catch
            {
                MessageBox.Show("Lỗi", currently_selected.ToString());
            }
            tam_table.AcceptChanges();
            this.Refresh();
        }

        private void btn_delete_all_Click(object sender, EventArgs e)
        {
            tam_table = (DataTable)tbl_giaodich.DataSource;
            for (int i = 0; i < tam_table.Rows.Count; i++)
                //try
                {
                    long tien_tinh_lai = (long)(double.Parse(tam_table.Rows[i].Field<string>(2)));
                    sdu = long.Parse(txt_so_du.Text);
                    sdu += tien_tinh_lai;
                    txt_so_du.Text = sdu.ToString();
                    tam_table.Rows[i].Delete();
                }
                //catch
                //{
                //    MessageBox.Show("Lỗi delete all", i.ToString());
                //}
            tam_table.Clear();
            tbl_giaodich.DataSource = tam_table;
        }

        private void btn_begin_Click(object sender, EventArgs e)
        {
            External_SQL_Data_Bridge chay_gd = new External_SQL_Data_Bridge();
            DataTable sogd = chay_gd.Fill_Data_Table("select * from sangiaodich.dbo.lichsu_nd");
            long magd = sogd.Rows.Count;

            DataTable tam_gd = (DataTable)tbl_giaodich.DataSource;
            string cau_lenh_sql = "insert into sangiaodich.dbo.lichsu_nd values (" + magd.ToString() + ",'" + GlobalVariable.ten_kh + "',N'" + txt_ghi_chu.Text + "')";
            chay_gd.chạy_lệnh_SQL(cau_lenh_sql);

            for (int i = 0; i < tam_gd.Rows.Count; i++)
            {
                DateTime time = DateTime.Now;              // Use current time
                string format = "yyyy-MM-dd HH:mm:ss";    // modify the format depending upon input required in the column in database 
                string thoigianhientai = time.ToString(format);

                try
                {
                    cau_lenh_sql = "insert into sangiaodich.dbo.chitietgd_nguoi_dung values (" + magd.ToString() + ",'" + tam_gd.Rows[i].Field<string>(0) + "',N'" + tam_gd.Rows[i].Field<string>(1) + "',N'" + thoigianhientai + "')";
                    chay_gd.chạy_lệnh_SQL(cau_lenh_sql);
                }
                catch
                {
                    cau_lenh_sql = "update sangiaodich.dbo.chitietgd_nguoi_dung set [Số tiền giao dịch] = [Số tiền giao dịch] + " + tam_gd.Rows[i].Field<string>(1) + " where [Mã Giao Dịch] = " + magd.ToString() + " and [Tên tài khoản nhận] = '" + tam_gd.Rows[i].Field<string>(0) + "'";
                    chay_gd.chạy_lệnh_SQL(cau_lenh_sql);
                }


                cau_lenh_sql = "update sangiaodich.dbo.nguoidung set [Số dư] = [Số dư] + '" + tam_gd.Rows[i].Field<string>(1) + "' where [Tên tài khoản] = N'" + tam_gd.Rows[i].Field<string>(0) + "'";
                chay_gd.chạy_lệnh_SQL(cau_lenh_sql);
            }

            cau_lenh_sql = "update sangiaodich.dbo.nguoidung set [Số dư] = '" + txt_so_du.Text + "' where [Tên tài khoản] = N'" + GlobalVariable.ten_kh + "'";
            chay_gd.chạy_lệnh_SQL(cau_lenh_sql);

            btn_delete_all_Click(sender, e);
            btn_reset_panel_Click(sender, e);
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text))
            {
                usersearch.DataSource = temp_nap.Fill_Data_Table("select [Tên tài khoản] from sangiaodich.dbo.nguoidung where  [Tên tài khoản] != '" + GlobalVariable.ten_kh + "'");
            }
            else
            {
                DataTable temp_usersearch = new DataTable();
                temp_usersearch = temp_nap.Fill_Data_Table("select [Tên tài khoản] from sangiaodich.dbo.nguoidung where  [Tên tài khoản] != '" + GlobalVariable.ten_kh + "'");

                for (int i = 0; i < temp_usersearch.Rows.Count; i++)
                {
                    if (CommonFormFunctions.Kiểm_tra_trung(txt_username.Text, temp_usersearch.Rows[i].Field<string>(0)) == false)
                    {
                        temp_usersearch.Rows[i].Delete();
                    }
                }
                temp_usersearch.AcceptChanges();
                if (temp_usersearch.Rows.Count == 0)
                {
                    MessageBox.Show("Khong co nguoi dung nao co ten can tim");
                    usersearch.DataSource = temp_nap.Fill_Data_Table("select [Tên tài khoản] from sangiaodich.dbo.nguoidung where  [Tên tài khoản] != '" + GlobalVariable.ten_kh + "'");
                    GlobalVariable.global_thử_Nghiệm_Main_Menu.Refresh();
                    txt_username.Text = "";
                    return;
                }

                usersearch.DataSource = temp_usersearch;
            }
        }

        private void usersearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int vi_tri = usersearch.CurrentRow.Index;
            txt_final.Text = usersearch.Rows[vi_tri].Cells[0].Value.ToString();
        }

        private void txt_tien_TextChanged(object sender, EventArgs e)
        {
            if (txt_tien.Text.Trim() == "")
            {
            }
            else
                txt_phi.Text = (long.Parse(txt_tien.Text) * 0.015).ToString();
        }

        private void tbl_giaodich_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btn_begin.Enabled = true;
        }

        private void tbl_giaodich_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (tbl_giaodich.Rows.Count == 0)
            {
                btn_begin.Enabled = false;
                btn_delete.Enabled = false;
                btn_delete_all.Enabled = false;
            }
        }

        private void txt_tien_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void tbl_giaodich_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Entered");
            btn_delete.Enabled = true;
            btn_delete_all.Enabled = true;
            //tbl_giaodich.SelectedRows.
        }
    }
}
