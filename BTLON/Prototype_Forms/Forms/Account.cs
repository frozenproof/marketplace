using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

using Excel = Microsoft.Office.Interop.Excel;
namespace BTLON.Prototype_Forms.Forms
{
    public partial class Account : Form
    {
        public External_SQL_Data_Bridge tamnd = new External_SQL_Data_Bridge();
        bool[] changed_field = new bool[10];
        public Account()
        {
            InitializeComponent();
        }

      
        private void Account_Load(object sender, EventArgs e)
        {
             DataTable tam = new DataTable();
            tam = tamnd.Fill_Data_Table("select * from sangiaodich.dbo.nguoidung where [Tên tài khoản] = N'" + GlobalVariable.ten_kh + "'");
            txt_ten_tk.Text = GlobalVariable.ten_kh;
            //SQL_Command_Testing_Pop_Up tamn = new SQL_Command_Testing_Pop_Up();
            //tamn.setTable(tam);
            //tamn.Show();
            txt_ho_ten.Text = tam.Rows[0].Field<string>(0);
            txt_sdt.Text = tam.Rows[0].Field<string>(1);
            txt_dia_chi.Text = tam.Rows[0].Field<string>(2);
            txt_so_du.Text = tam.Rows[0].Field<long>(3).ToString();
            txt_stno.Text = tam.Rows[0].Field<long>(4).ToString();
            txt_gt.Text = tam.Rows[0].Field<string>(5);
            lbl_confirm.Visible = false;
            lbl_confirm.Enabled = false;
            try
            {
                pt_avatar.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Image\\" + tam.Rows[0].Field<string>(8));
            }
            catch
            {
                pt_avatar.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Image\\3ab10c1ce9c7bfb54c470c2caab2ebf6.png");
            }
              this.Refresh();
            ten_bang.SelectedIndex = 0;
        }

        private void btn_avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog mở_file = new OpenFileDialog();
            //mở_file.Filter = "JPEG|*.jpg|PNG|*.png|All|*.*"/*;*/
            mở_file.Filter = "All|*.*";
            mở_file.FilterIndex = 1;
            if (mở_file.ShowDialog() == DialogResult.OK)
            {
                string diachianh = mở_file.FileName;
                pt_avatar.BackgroundImage = Image.FromFile(diachianh);
                string[] diachianhtam = diachianh.Split('\\');
                string avatar = diachianhtam[diachianhtam.Length - 1];
                tamnd.chạy_lệnh_SQL("update sangiaodich.dbo.nguoidung set [Avatar]='" + avatar + "' where [Tên tài khoản] = N'" + GlobalVariable.ten_kh + "'");
            }
        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {
            lbl_confirm.Visible = true;
            lbl_confirm.Enabled = true;
        }

        public void Open_child_form(Form Child_form)
        {
            Child_form.TopLevel = false;
            Child_form.FormBorderStyle = FormBorderStyle.None;
            Child_form.Dock = DockStyle.Fill;
            panel1.Controls.Add(Child_form);
            panel1.Tag = Child_form;
            Child_form.BringToFront();
            Child_form.Show();
        }
        private void btn_change_password_Click(object sender, EventArgs e)
        {
            Open_child_form(new PasswordChange());
            this.Refresh();
        }

        private void lbl_confirm_Click(object sender, EventArgs e)
        {
            External_SQL_Data_Bridge bridge = new External_SQL_Data_Bridge();
            string update_nd = "update sangiaodich.dbo.nguoidung set ";
            update_nd = update_nd + " [Tên tài khoản] = '" + txt_ten_tk.Text + "'";
            update_nd = update_nd + ", [Tên người dùng] = '" + txt_ho_ten.Text + "'";
            update_nd = update_nd + ", [Giới tính] = '" + txt_gt.Text + "'";
            update_nd = update_nd + ", [Địa chỉ] = '" + txt_dia_chi.Text + "'";
            update_nd = update_nd + ",[Số điện thoại] = '" + txt_sdt.Text + "'";

            update_nd = update_nd + " where [Tên tài khoản] = '" + GlobalVariable.ten_kh + "'";
            try
            {
                bridge.chạy_lệnh_SQL(update_nd);
            }
            catch
            {
                update_nd = "update sangiaodich.dbo.nguoidung set ";
                update_nd = update_nd + " [Tên người dùng] = '" + txt_ho_ten.Text + "'";
                update_nd = update_nd + ", [Giới tính] = '" + txt_gt.Text + "'";
                update_nd = update_nd + ", [Địa chỉ] = '" + txt_dia_chi.Text + "'";
                update_nd = update_nd + ",[Số điện thoại] = '" + txt_sdt.Text + "'";

                update_nd = update_nd + " where [Tên tài khoản] = '" + GlobalVariable.ten_kh + "'";
                bridge.chạy_lệnh_SQL(update_nd);
            }
            GlobalVariable.ten_kh = txt_ten_tk.Text;
            lbl_confirm.Visible = false;
            lbl_confirm.Enabled = false;
        }



        private void btn_tong_hop_Click(object sender, EventArgs e)
        {
            External_SQL_Data_Bridge temp = new External_SQL_Data_Bridge();
            DataTable but = temp.Fill_Data_Table("select [Số điện thoại], [Địa chỉ] from sangiaodich.dbo.nguoidung where[Tên tài khoản] = '" + GlobalVariable.ten_kh + "'");
            DataTable dtHang = (DataTable)Sum_table.DataSource;
            if (dtHang.Rows.Count > 0) //TH có dữ liệu để ghi
            {
                //Khai báo và khởi tạo các đối tượng
                Microsoft.Office.Interop.Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                //Định dạng chung
                Excel.Range TieuDe = (Excel.Range)exSheet.Cells[1, 1];
                TieuDe.Font.Size = 12;
                TieuDe.Font.Bold = true;
                TieuDe.Font.Color = Color.Blue;
                TieuDe.Value = "TỔNG HỢP CỔ PHẦN CHỨNG KHOÁN";
                Excel.Range Diachi = (Excel.Range)exSheet.Cells[2, 1];
                Diachi.Font.Size = 12;
                Diachi.Font.Bold = true;
                Diachi.Font.Color = Color.Blue;
                Diachi.Value = but.Rows[0].Field<string>(1);
                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                dtCuaHang.Font.Size = 12;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Blue;
                dtCuaHang.Value = "Điện thoại:" + but.Rows[0].Field<string>(0);
                Excel.Range header = (Excel.Range)exSheet.Cells[5, 2];
                exSheet.get_Range("B5:H5").Merge(true);
                header.Font.Size = 13;
                header.Font.Bold = true;
                header.Font.Color = Color.Red;
                header.Value = "USER " + GlobalVariable.ten_kh;
                //Định dạng tiêu đề bảng

                exSheet.get_Range("A7:H7").Font.Bold = true;
                exSheet.get_Range("A7:H7").HorizontalAlignment =
               Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A7").Value = "STT";
                exSheet.get_Range("A7").ColumnWidth = 9;
                exSheet.get_Range("B7").Value = "Mã kinh doanh";
                exSheet.get_Range("B7").ColumnWidth = 19;
                exSheet.get_Range("C7").Value = "Số cổ phiếu";
                exSheet.get_Range("C7").ColumnWidth = 32;

                //In dữ liệu
                for (int i = 0; i < dtHang.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 8).ToString() + ":F" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("B" + (i + 8).ToString()).Value = dtHang.Rows[i]["Mã kinh doanh"].ToString();
                    exSheet.get_Range("C" + (i + 8).ToString()).Value = dtHang.Rows[i]["Số cổ phiếu"].ToString();

                }
                exSheet.Name = "HDBan";
                exBook.Activate(); //Kích hoạt file Excel
                                   //Thiết lập các thuộc tính của SaveFileDialog
                SaveFileDialog dlgSave = new SaveFileDialog();
                dlgSave.Filter = "Excel Document(*.xlsx)|*.xlsx |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";
                dlgSave.FilterIndex = 1;
                dlgSave.AddExtension = true;
                dlgSave.DefaultExt = ".xlsx";
                if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
                exApp.Quit();//Thoát khỏi ứng dụng
            }
            else
                MessageBox.Show("Không có danh sách để in");
        }

        private void btn_nd_tong_hop_Click(object sender, EventArgs e)
        {
            External_SQL_Data_Bridge temp = new External_SQL_Data_Bridge();
            DataTable but = temp.Fill_Data_Table("select [Số điện thoại], [Địa chỉ] from sangiaodich.dbo.nguoidung where[Tên tài khoản] = '" + GlobalVariable.ten_kh + "'");
            DataTable dtHang = (DataTable)Sum_table.DataSource;
            if (dtHang.Rows.Count > 0) //TH có dữ liệu để ghi
            {
                //Khai báo và khởi tạo các đối tượng
                Microsoft.Office.Interop.Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                //Định dạng chung
                Excel.Range TieuDe = (Excel.Range)exSheet.Cells[1, 1];
                TieuDe.Font.Size = 12;
                TieuDe.Font.Bold = true;
                TieuDe.Font.Color = Color.Blue;
                TieuDe.Value = "LỊCH SỬ CHUYỂN TIỀN";
                Excel.Range Diachi = (Excel.Range)exSheet.Cells[2, 1];
                Diachi.Font.Size = 12;
                Diachi.Font.Bold = true;
                Diachi.Font.Color = Color.Blue;
                Diachi.Value = but.Rows[0].Field<string>(1);
                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                dtCuaHang.Font.Size = 12;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Blue;
                dtCuaHang.Value = "Điện thoại:" + but.Rows[0].Field<string>(0);
                Excel.Range header = (Excel.Range)exSheet.Cells[5, 2];
                exSheet.get_Range("B5:H5").Merge(true);
                header.Font.Size = 13;
                header.Font.Bold = true;
                header.Font.Color = Color.Red;
                header.Value = "USER " + GlobalVariable.ten_kh;
                //Định dạng tiêu đề bảng

                exSheet.get_Range("A7:H7").Font.Bold = true;
                exSheet.get_Range("A7:H7").HorizontalAlignment =
               Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A7").Value = "STT";
                exSheet.get_Range("A7").ColumnWidth = 9;
                exSheet.get_Range("B7").Value = "Mã giao dịch";
                exSheet.get_Range("B7").ColumnWidth = 19;
                exSheet.get_Range("C7").Value = "Tên tài khoản nhận";
                exSheet.get_Range("C7").ColumnWidth = 19;
                exSheet.get_Range("D7").Value = "Số tiền chuyển";
                exSheet.get_Range("D7").ColumnWidth = 32;
                exSheet.get_Range("E7").Value = "Thời gian chuyển";
                exSheet.get_Range("E7").ColumnWidth = 32;

                //In dữ liệu
                for (int i = 0; i < dtHang.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 8).ToString() + ":F" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("B" + (i + 8).ToString()).Value = dtHang.Rows[i]["Mã giao dịch"].ToString();
                    exSheet.get_Range("C" + (i + 8).ToString()).Value = dtHang.Rows[i]["Tên tài khoản nhận"].ToString();
                    exSheet.get_Range("D" + (i + 8).ToString()).Value = dtHang.Rows[i]["Số tiền giao dịch"].ToString();
                    exSheet.get_Range("E" + (i + 8).ToString()).Value = dtHang.Rows[i]["Ngày giao dịch"].ToString();

                }
                exSheet.Name = "HDBan";
                exBook.Activate(); //Kích hoạt file Excel
                                   //Thiết lập các thuộc tính của SaveFileDialog
                SaveFileDialog dlgSave = new SaveFileDialog();
                dlgSave.Filter = "Excel Document(*.xlsx)|*.xlsx |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";
                dlgSave.FilterIndex = 1;
                dlgSave.AddExtension = true;
                dlgSave.DefaultExt = ".xlsx";
                if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
                exApp.Quit();//Thoát khỏi ứng dụng
            }
            else
                MessageBox.Show("Không có danh sách để in");
        }

        private void ten_bang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ten_bang.Text == "Chứng Khoán")
            {
                DataTable history = tamnd.Fill_Data_Table("select [Mã kinh doanh],[Số cổ phiếu] from sangiaodich.dbo.tongket where [Tên tài khoản]='" + GlobalVariable.ten_kh + "'");
                Sum_table.DataSource = history;
            }
            if (ten_bang.Text == "Chuyển Tiền")
            {
                DataTable history = tamnd.Fill_Data_Table("select sangiaodich.dbo.chitietgd_nguoi_dung.[Mã Giao Dịch],[Tên tài khoản nhận],[Số tiền giao dịch],[Ngày giao dịch],[Ghi chú giao dịch] from sangiaodich.dbo.chitietgd_nguoi_dung,sangiaodich.dbo.lichsu_nd where sangiaodich.dbo.chitietgd_nguoi_dung.[Mã Giao Dịch] = sangiaodich.dbo.lichsu_nd.[Mã Giao Dịch] and [Tên tài khoản gửi] = '"+GlobalVariable.ten_kh+ "'");
                Sum_table.DataSource = history;
            }
        }

        private void btn_tong_hop_Click1(object sender, EventArgs e)
        {
            if (ten_bang.Text== "Chứng Khoán")
            {
                btn_tong_hop_Click(sender,e);
            }
            if (ten_bang.Text == "Chuyển Tiền")
            {
                btn_nd_tong_hop_Click(sender, e);
            }
           
        }
    }
}
