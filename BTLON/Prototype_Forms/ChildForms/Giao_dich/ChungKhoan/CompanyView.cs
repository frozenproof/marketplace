using BTLON.SQL_CONNECT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BTLON.Prototype_Forms.ChildForms.Theo_doi.Views
{
    public partial class CompanyView : Form
    {
        private DataTable tbl_goc = new DataTable();
        private DataTable tbl_tam = new DataTable();
        public DataTable tbl_nd = new DataTable();
        public DataTable tbl_nd_goc = new DataTable();
        public DataTable tam_table = new DataTable();
        public Queue<string> selected_name = new Queue<string>();
        public long sdu;

        public External_SQL_Data_Bridge sql_bash = new External_SQL_Data_Bridge();

        public string[] company_name = { "[Giá hiện tại]", "[Giá tham chiếu]", "[Giá trần]", "[Giá sàn]", "[Số cổ phần giao dich]" };
        public string[] gd_name = { "[Mã kinh doanh]", "[Số lượng cổ phiếu]", "[Loại giao dịch]", "[Tổng số tiền giao dịch]" };


        private void CompanyViewLoad(object sender, EventArgs e)
        {
            tab_company.SelectedTab = tab_company.TabPages["Company View"];
            try
            {
                tạo_lại_bảng_gốc();
            }
            catch
            {
                return;
            }

            tbl_company.DataSource = tbl_goc;
            tab_company.SelectedTab = tab_company.TabPages["tabPage1"];
            CommonFormFunctions.thêm_cột_vào_bảng(tbl_tam, gd_name);
            tbl_company.AllowUserToAddRows = false;
            tbl_company.RowHeadersVisible = false;
            tbl_giaodich.AllowUserToAddRows = false;
            tbl_giaodich.RowHeadersVisible = false;
            cbo_gia.SelectedIndex = 0;
            cbo_cp_gd.SelectedIndex = 0;
            cbo_ht_gd.SelectedIndex = 0;
            tbl_giaodich.DataSource = tam_table;
            btn_reset_Click(sender, e);
        }

        public void tạo_lại_bảng_gốc()
        {
            External_SQL_Data_Bridge sql_bash = new External_SQL_Data_Bridge();
            try
            {
                tbl_goc = sql_bash.Fill_Data_Table("select [Mã kinh doanh],[Giá hiện tại],[Giá tham chiếu], [Giá trần], [Giá sàn], [Số cổ phần available] as [Số cổ phần giao dịch] from sangiaodich.dbo.congty where [Số cổ phần available] >= '0'");
            }
            catch
            {
                MessageBox.Show("Khong ton tai");
            }
        }


        //Events
        public CompanyView()
        {
            InitializeComponent();

        }

        private void tbl_company_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            External_SQL_Data_Bridge covid = new External_SQL_Data_Bridge();

            txt_co_phieu.Enabled = true;
            btn_add.Enabled = true;
            btn_reset.Enabled = true;
            if (tbl_company.SelectedCells.Count > 0)
            {
                int rowindex = tbl_company.CurrentCell.RowIndex;
                int columnindex = 0;
                txt_ma_kinh_doanh.Text = tbl_company.Rows[rowindex].Cells[columnindex].Value.ToString();
                txt_gia_gd.Text = tbl_company.Rows[rowindex].Cells[1].Value.ToString();
                txt_cong_ty_co_phan.Text = tbl_company.Rows[rowindex].Cells[5].Value.ToString();
            }
            tab_company.SelectedTab = tab_company.TabPages["tabPage2"];

            DataTable tamp = covid.Fill_Data_Table("select[Tên công ty], [Địa chỉ công ty], [Tổng số tiền] from sangiaodich.dbo.congty where [Mã kinh doanh] = '" + txt_ma_kinh_doanh.Text + "'");
            if (tamp.Rows.Count == 0)
            {
                txt_cp_giu.Text = "0";
            }
            else
            {
                txt_cp_giu.Text = tamp.Rows[0].Field<long>(2).ToString();
            }
            if (txt_cong_ty_co_phan.Text == "0")
            {
                cbo_ht_gd.SelectedIndex = 1;
                cbo_ht_gd.Enabled = false;
            }
            txt_ten_cty.Text = tamp.Rows[0].Field<string>(0);
            txt_dia_chi.Text = tamp.Rows[0].Field<string>(1);
            txt_tong.Text = tamp.Rows[0].Field<long>(2).ToString();
            GlobalVariable.global_thử_Nghiệm_Main_Menu.Refresh();

        }

        //tim kiem cong ty

        //bat dau khoi tao giao dich hang loat
        private void btn_begin_Click(object sender, EventArgs e)
        {
            External_SQL_Data_Bridge chay_gd = new External_SQL_Data_Bridge();
            string cau_lenh_sql;
            DataTable sogd = chay_gd.Fill_Data_Table("select * from sangiaodich.dbo.lichsu_cty");
            long magd = sogd.Rows.Count;

            DataTable tam_gd = (DataTable)tbl_giaodich.DataSource;
            cau_lenh_sql = "insert into sangiaodich.dbo.lichsu_cty values (" + magd.ToString() + ",'" + GlobalVariable.ten_kh + "',N'" + txt_ghi_chu.Text + "')";
            chay_gd.chạy_lệnh_SQL(cau_lenh_sql);

            Stack<string> ten_congty_can_update = new Stack<string>();

            for (int i = 0; i < tam_gd.Rows.Count; i++)
            {
                ten_congty_can_update.Push(tam_gd.Rows[i].Field<string>(0));
                if (tam_gd.Rows[i].Field<string>(2) == "Mua")
                {
                    cau_lenh_sql = "update sangiaodich.dbo.congty set [Số cổ phần available] = [Số cổ phần available] - '" + tam_gd.Rows[i].Field<string>(1) + "' where[Mã kinh doanh] = '" + tam_gd.Rows[i].Field<string>(0) + "'";
                    chay_gd.chạy_lệnh_SQL(cau_lenh_sql);

                    cau_lenh_sql = "update sangiaodich.dbo.congty set [Tổng số tiền] = [Tổng số tiền] + '" + (long)double.Parse(tam_gd.Rows[i].Field<string>(3)) + "' where[Mã kinh doanh] = '" + tam_gd.Rows[i].Field<string>(0) + "'";
                    chay_gd.chạy_lệnh_SQL(cau_lenh_sql);

                    try
                    {
                        cau_lenh_sql = "insert into sangiaodich.dbo.chitietgd_co_phieu values (" + magd.ToString() + ",'Mua','" + tam_gd.Rows[i].Field<string>(0) + "','" + tam_gd.Rows[i].Field<string>(1) + "')";
                        chay_gd.chạy_lệnh_SQL(cau_lenh_sql);
                    }
                    catch
                    {
                        cau_lenh_sql = "update sangiaodich.dbo.chitietgd_co_phieu set [Số cổ phiếu giao dịch] = [Số cổ phiếu giao dịch] + " + tam_gd.Rows[i].Field<string>(1) + "where [Mã Giao Dịch] = " + magd.ToString() + "and [Mã kinh doanh] = '" + tam_gd.Rows[i].Field<string>(0) + "' and [Loại giao dịch] ='Mua'";
                        chay_gd.chạy_lệnh_SQL(cau_lenh_sql);
                    }

                    try
                    {
                        cau_lenh_sql = "insert into sangiaodich.dbo.tongket values ('" + GlobalVariable.ten_kh + "','" + tam_gd.Rows[i].Field<string>(0) + "','" + tam_gd.Rows[i].Field<string>(1) + "')";
                        chay_gd.chạy_lệnh_SQL(cau_lenh_sql);
                    }
                    catch
                    {
                        cau_lenh_sql = "update sangiaodich.dbo.tongket set [Số cổ phiếu] = [Số cổ phiếu] + " + tam_gd.Rows[i].Field<string>(1) + " where [Mã kinh doanh] = '" + tam_gd.Rows[i].Field<string>(0) + "' and [Tên tài khoản] = '" + GlobalVariable.ten_kh + "'";
                        chay_gd.chạy_lệnh_SQL(cau_lenh_sql);
                    }

                }
                else if (tam_gd.Rows[i].Field<string>(2) == "Bán")
                {
                    cau_lenh_sql = "update sangiaodich.dbo.congty set [Số cổ phần available] = [Số cổ phần available] + '" + tam_gd.Rows[i].Field<string>(1) + "' where[Mã kinh doanh] = '" + tam_gd.Rows[i].Field<string>(0) + "'";
                    chay_gd.chạy_lệnh_SQL(cau_lenh_sql);

                    cau_lenh_sql = "update sangiaodich.dbo.congty set [Tổng số tiền] = [Tổng số tiền] - '" + (long)double.Parse(tam_gd.Rows[i].Field<string>(3)) + "' where[Mã kinh doanh] = '" + tam_gd.Rows[i].Field<string>(0) + "'";
                    chay_gd.chạy_lệnh_SQL(cau_lenh_sql);

                    try
                    {
                        cau_lenh_sql = "insert into sangiaodich.dbo.chitietgd_co_phieu values (" + magd.ToString() + ",'Bán','" + tam_gd.Rows[i].Field<string>(0) + "','" + tam_gd.Rows[i].Field<string>(1) + "')";
                        chay_gd.chạy_lệnh_SQL(cau_lenh_sql);
                    }
                    catch
                    {
                        cau_lenh_sql = "update sangiaodich.dbo.chitietgd_co_phieu set [Số cổ phiếu giao dịch] = [Số cổ phiếu giao dịch] + " + tam_gd.Rows[i].Field<string>(1) + "where [Mã Giao Dịch] = " + magd.ToString() + "and [Mã kinh doanh] = '" + tam_gd.Rows[i].Field<string>(0) + "' and [Loại giao dịch] ='Bán' ";
                        chay_gd.chạy_lệnh_SQL(cau_lenh_sql);
                    }

                    cau_lenh_sql = "update sangiaodich.dbo.tongket set [Số cổ phiếu] = [Số cổ phiếu] - " + tam_gd.Rows[i].Field<string>(1) + " where [Mã kinh doanh] = '" + tam_gd.Rows[i].Field<string>(0) + "' and [Tên tài khoản] = '" + GlobalVariable.ten_kh + "'";
                    chay_gd.chạy_lệnh_SQL(cau_lenh_sql);

                }

                //chinh lai gia tien
                while (ten_congty_can_update.Count > 0)
                {
                    string update_cty;
                    update_cty = "update sangiaodich.dbo.congty set [Giá hiện tại] = [Tổng số tiền] / ( [Tổng số cổ phần] - [Số cổ phần available]) where [Mã kinh doanh] = '" + ten_congty_can_update.Peek() + "'";
                    chay_gd.chạy_lệnh_SQL(update_cty);
                    ten_congty_can_update.Pop();
                }

                cau_lenh_sql = "update sangiaodich.dbo.nguoidung set [Số dư] = '" + txt_so_du.Text + "' where [Tên tài khoản] = N'" + GlobalVariable.ten_kh + "'";
                chay_gd.chạy_lệnh_SQL(cau_lenh_sql);

                //MessageBox.Show("update sangiaodich.dbo.nguoidung set [Số dư] = '" + txt_so_du.Text + "' where [Tên tài khoản] = N'" + GlobalVariable.ten_kh + "'");
                tab_company.SelectedTab = tab_company.TabPages["tabPage1"];
                btn_reset_Click(sender, e);
                btn_delete_all_Click(sender, e);
                tạo_lại_bảng_gốc();
                tbl_company.DataSource = tbl_goc;
            }
        }


        //giai quyet van de usser interface cua giao dich
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_co_phieu.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ.");
                return;
            }
            foreach (Control tam in panel_gd.Controls)
            {
                if (tam.GetType() == typeof(TextBox))
                {
                    if (string.IsNullOrEmpty(tam.Text))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ.");
                        return;
                    }
                }
            }
            sdu = long.Parse(txt_so_du.Text);
            double tam_tien = long.Parse(txt_gia_gd.Text) * long.Parse(txt_co_phieu.Text);
            double phi = double.Parse(txt_phi.Text);

            //chinh sua lai bang tam thoi
            DataTable banggd = (DataTable)(tbl_company.DataSource);
            for (int i = 0; i < banggd.Rows.Count; i++)
            {
                if (banggd.Rows[i].Field<string>(0) == txt_ma_kinh_doanh.Text)
                {
                    if (cbo_ht_gd.Text == "Bán")
                    {
                        long socp = long.Parse(txt_co_phieu.Text);
                        banggd.Rows[i][5] = banggd.Rows[i].Field<long>(5) + socp;
                        txt_cp_giu.Text = (long.Parse(txt_cp_giu.Text) - socp).ToString();
                    }
                    else
                    {
                        long socp = long.Parse(txt_co_phieu.Text);
                        banggd.Rows[i][5] = banggd.Rows[i].Field<long>(5) - socp;
                        txt_cp_giu.Text = (long.Parse(txt_cp_giu.Text) + socp).ToString();
                    }
                }
            }

            long sdu_goc = sdu;

            if (cbo_ht_gd.Text == "Bán")
            {
                sdu += (long)(tam_tien);
                txt_so_du.Text = sdu.ToString();
            }
            if (cbo_ht_gd.Text == "Mua")
            {
                sdu -= (long)(tam_tien);
                txt_so_du.Text = sdu.ToString();
            }

            sdu = sdu - (long)phi;
            if (sdu < 0)
            {
                MessageBox.Show("Không đủ tiền.");
                txt_so_du.Text = sdu_goc.ToString();
                return;
            }
            //MessageBox.Show(txt_so_du.Text);

            int current_rows_number = tam_table.Rows.Count;
            tam_table.Rows.InsertAt(tam_table.NewRow(), current_rows_number);
            CommonFormFunctions.thêm_cột_vào_bảng(tam_table, gd_name);
            //MessageBox.Show(tam_table.Columns.Count.ToString());
            tam_table.Rows[current_rows_number][0] = txt_ma_kinh_doanh.Text;
            tam_table.Rows[current_rows_number][1] = txt_co_phieu.Text;
            tam_table.Rows[current_rows_number][2] = cbo_ht_gd.Text;

            string tinh_tien = tam_tien.ToString();
            tam_table.Rows[current_rows_number][3] = tinh_tien;
            tbl_giaodich.DataSource = tam_table;

            txt_so_du.Text = sdu.ToString();

            tab_company.SelectedTab = tab_company.TabPages["tabPage1"];
            btn_reset_Click(sender, e);
        }


        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        private void txt_cp_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }


        private void tbl_giaodich_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (tbl_giaodich.RowCount == 0)
            {
                btn_begin.Enabled = false;
                btn_delete.Enabled = false;
                btn_delete_all.Enabled = false;
            }
        }

        private void tbl_giaodich_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btn_begin.Enabled = true;
        }

        private void tbl_giaodich_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btn_delete.Enabled = true;
            btn_delete_all.Enabled = true;
        }


        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dung_tam_cong_ty = (DataTable)tbl_company.DataSource;

            bool txt = false;
            bool dau_gia = false;
            bool dau_co_phieu = false;
            bool txt_lon_hon_gia = false;

            for (int i = 0; i < dung_tam_cong_ty.Rows.Count; i++)
            {
                //gia_cp
                if (txt_gia_hien_tai.Text.Trim() == "")
                {
                    dau_gia = true;
                }
                else
                {
                    bool dau_cb = false;
                    if (cbo_gia.Text == ">")
                        dau_cb = true;
                    else
                        dau_cb = false;

                    txt_lon_hon_gia = dung_tam_cong_ty.Rows[i].Field<long>(1) > long.Parse(txt_gia_hien_tai.Text);

                    if (txt_lon_hon_gia & dau_cb)
                    {
                        dau_gia = true;
                    }
                    else
                    {
                        dau_gia = false;
                    }
                }

                //cp_gd
                if (txt_cp_gd.Text.Trim() == "")
                {
                    dau_co_phieu = true;
                }
                else
                {
                    bool dau_cb = false;

                    if (cbo_cp_gd.Text == ">")
                        dau_cb = true;
                    else
                        dau_cb = false;

                    txt_lon_hon_gia = dung_tam_cong_ty.Rows[i].Field<long>(5) > long.Parse(txt_cp_gd.Text);

                    if (txt_lon_hon_gia & dau_cb)
                    {
                        dau_co_phieu = true;
                    }
                    else
                    {
                        dau_co_phieu = false;
                    }
                }

                if (txt_search.Text.Trim() == "")
                {
                    txt = true;
                }
                else
                {
                    if (CommonFormFunctions.Kiểm_tra_trung(txt_search.Text.Trim(), tbl_goc.Rows[i].Field<string>(0)) == false)
                        txt = false;
                    else
                        txt = true;
                }
                //MessageBox.Show("txt=" + txt + "|dau co phieu=" + dau_co_phieu + "|dau gia=" + dau_gia + tbl_company.Rows[i].Cells[0].Value);

                if ((dau_gia & txt & dau_co_phieu) == true)
                {
                    if (tbl_company.Rows[i].Visible == false)
                        try
                        {
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[tbl_company.DataSource];
                            currencyManager1.SuspendBinding();
                            tbl_company.Rows[i].Visible = true;
                            currencyManager1.ResumeBinding();
                        }
                        catch
                        {
                        }
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[tbl_company.DataSource];
                    currencyManager1.SuspendBinding();
                    tbl_company.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
            tbl_company.DataSource = dung_tam_cong_ty;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int currently_selected;
            currently_selected = tbl_giaodich.CurrentRow.Index;
            if (tam_table.Rows[currently_selected].Field<string>(2) == "Mua")
            {
                try
                {
                    long tien_tinh_lai = (long)(double.Parse(tam_table.Rows[currently_selected].Field<string>(3)) / 0.985);
                    sdu = long.Parse(txt_so_du.Text);
                    sdu += tien_tinh_lai;
                    txt_so_du.Text = sdu.ToString();
                    tam_table.Rows[currently_selected].Delete();
                }
                catch
                {
                    MessageBox.Show("Lỗi delete ");
                }
            }
            else
            {
                try
                {
                    long tien_tinh_lai = (long)(double.Parse(tam_table.Rows[currently_selected].Field<string>(3)) / 0.985);
                    sdu = long.Parse(txt_so_du.Text);
                    sdu -= tien_tinh_lai;
                    txt_so_du.Text = sdu.ToString();
                    tam_table.Rows[currently_selected].Delete();
                }
                catch
                {
                    MessageBox.Show("Lỗi delete ");
                }
            }

        }

        private void btn_delete_all_Click(object sender, EventArgs e)
        {
            tam_table = (DataTable)tbl_giaodich.DataSource;
            for (int i = 0; i < tam_table.Rows.Count; i++)
                try
                {
                    long tien_tinh_lai = (long)(double.Parse(tam_table.Rows[i].Field<string>(3)) / 0.985);
                    sdu = long.Parse(txt_so_du.Text);
                    sdu += tien_tinh_lai;
                    txt_so_du.Text = sdu.ToString();
                    tam_table.Rows[i].Delete();
                }
                catch
                {
                    MessageBox.Show("Lỗi delete all");
                }
            tam_table.Clear();
            tbl_giaodich.DataSource = tam_table;
        }

        private void btn_reset_search_Click(object sender, EventArgs e)
        {
            foreach (Control tam in panel_search.Controls)
            {
                if (tam.GetType() == typeof(TextBox))
                {
                    tam.Text = "";
                }
            }
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            DataTable temp_table = new DataTable();

            if (string.IsNullOrEmpty(txt_so_du.Text.Trim()))
            {
                temp_table = sql_bash.Fill_Data_Table("select [Số dư] from sangiaodich.dbo.nguoidung where [Tên tài khoản]='" + GlobalVariable.ten_kh + "'");
                txt_so_du.Text = temp_table.Rows[0].Field<long>(0).ToString();
                sdu = long.Parse(txt_so_du.Text);
            }
            else
            {
                sdu = long.Parse(txt_so_du.Text);
            }

            foreach (Control tam in panel_gd.Controls)
            {
                if (tam.GetType() == typeof(TextBox))
                {
                    tam.Text = "";
                }
            }
            foreach (Control tam in tab_company.TabPages["tabPage2"].Controls)
            {
                if (tam.GetType() == typeof(TextBox))
                {
                    tam.Text = "";
                }
            }

            tạo_lại_bảng_gốc();
            tab_company.SelectedTab = tab_company.TabPages["tabPage1"];
            txt_cp_giu.Text = "";
            txt_co_phieu.Enabled = false;
            btn_add.Enabled = false;
            btn_reset.Enabled = false;

            txt_so_du.Text = sdu.ToString();
        }

        private void txt_co_phieu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (long.Parse(txt_co_phieu.Text) >= long.Parse(txt_cong_ty_co_phan.Text))
                {
                    if (cbo_ht_gd.Text == "Mua")
                        txt_co_phieu.Text = txt_cong_ty_co_phan.Text.Trim();
                    if (cbo_ht_gd.Text == "Bán")
                        txt_co_phieu.Text = txt_cp_giu.Text.Trim();
                    return;
                }
            }
            catch
            {
            }
            try
            {
                txt_tong_tien.Text = (long.Parse(txt_gia_gd.Text) * long.Parse(txt_co_phieu.Text)).ToString();
                txt_phi.Text = (long.Parse(txt_tong_tien.Text) * 0.015).ToString();
            }
            catch
            {
            }
        }
    }
}
