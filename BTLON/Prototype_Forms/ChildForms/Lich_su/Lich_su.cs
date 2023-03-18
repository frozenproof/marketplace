using BTLON.SQL_CONNECT;
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

using Excel = Microsoft.Office.Interop.Excel;

namespace BTLON.Prototype_Forms.ChildForms.Lich_su
{
    public partial class Lich_su : Form
    {
        private bool dau_co_phieu;
        private bool txt_lon_hon_gia;

        public Lich_su()
        {
            InitializeComponent();
        }

        private void Lich_su_Load(object sender, EventArgs e)
        {
            load_bang();
            cbo_cp_gd.SelectedIndex = 0;
            string.Format("(0:MM/dd/yyyy)");//for time
        }
        void load_bang()
        {
            External_SQL_Data_Bridge external_SQL_Data_Bridge = new External_SQL_Data_Bridge();
            History_table.DataSource = external_SQL_Data_Bridge.Fill_Data_Table("select sangiaodich.dbo.chitietgd_co_phieu.[Mã Giao Dịch],[Ghi chú giao dịch],[Loại giao dịch],[Mã kinh doanh],[Số cổ phiếu giao dịch] from sangiaodich.dbo.lichsu_cty ,sangiaodich.dbo.chitietgd_co_phieu where sangiaodich.dbo.lichsu_cty.[Tên tài khoản] = '" + GlobalVariable.ten_kh + "' and sangiaodich.dbo.chitietgd_co_phieu.[Mã Giao Dịch]= sangiaodich.dbo.lichsu_cty.[Mã Giao Dịch]");

        }
        private void btn_report_Click(object sender, EventArgs e)
        {
            External_SQL_Data_Bridge temp = new External_SQL_Data_Bridge();
            DataTable but = temp.Fill_Data_Table("select [Số điện thoại], [Địa chỉ]  from sangiaodich.dbo.nguoidung where[Tên tài khoản] = '" + GlobalVariable.ten_kh+"'");
            DataTable dtHang = (DataTable)History_table.DataSource;
            if (dtHang.Rows.Count > 0) //TH có dữ liệu để ghi
            {
                //Khai báo và khởi tạo các đối tượng
                Microsoft.Office.Interop.Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                //Định dạng chung
                Excel.Range tieude = (Excel.Range)exSheet.Cells[1, 1];
                tieude.Font.Size = 12;
                tieude.Font.Bold = true;
                tieude.Font.Color = Color.Blue;
                tieude.Value = "LỊCH SỬ GIAO DỊCH CHỨNG KHOÁN";
                Excel.Range diachinguoidung = (Excel.Range)exSheet.Cells[2, 1];
                diachinguoidung.Font.Size = 12;
                diachinguoidung.Font.Bold = true;
                diachinguoidung.Font.Color = Color.Blue;
                diachinguoidung.Value = but.Rows[0].Field<string>(1);
                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                dtCuaHang.Font.Size = 12;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Blue;
                dtCuaHang.Value = "Điện thoại:"+ but.Rows[0].Field<string>(0);
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
                exSheet.get_Range("B7").Value = "Mã Giao Dịch";
                exSheet.get_Range("B7").ColumnWidth = 20;
                exSheet.get_Range("C7").Value = "Ghi chú giao dịch";
                exSheet.get_Range("C7").ColumnWidth = 20;
                exSheet.get_Range("D7").Value = "Loại giao dịch";
                exSheet.get_Range("D7").ColumnWidth = 26;
                exSheet.get_Range("E7").Value = "Mã kinh doanh";
                exSheet.get_Range("E7").ColumnWidth = 20;
                exSheet.get_Range("F7").Value = "Số cổ phiếu giao dịch";
                exSheet.get_Range("F7").ColumnWidth = 46;
                //In dữ liệu
                for (int i = 0; i < dtHang.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 8).ToString() + ":F" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("B" + (i + 8).ToString()).Value = dtHang.Rows[i]["Mã Giao Dịch"].ToString();
                    exSheet.get_Range("C" + (i + 8).ToString()).Value = dtHang.Rows[i]["Ghi chú giao dịch"].ToString();
                    exSheet.get_Range("D" + (i + 8).ToString()).Value = dtHang.Rows[i]["Loại giao dịch"].ToString();
                    exSheet.get_Range("E" + (i + 8).ToString()).Value = dtHang.Rows[i]["Mã kinh doanh"].ToString();
                    exSheet.get_Range("F" + (i + 8).ToString()).Value = dtHang.Rows[i]["Số cổ phiếu giao dịch"].ToString();
                  
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable tam = (DataTable)History_table.DataSource;
            for (int i = 0; i < History_table.Rows.Count; i++)
            {
                bool txt = false;
                //cp_gd
                if (txt_cp_gd.Text.Trim() == "")
                {
                    dau_co_phieu = true;
                }
                else
                {
                    bool dau_cp = false;

                    if (cbo_cp_gd.Text == ">")
                        dau_cp = true;
                    else
                        dau_cp = false;

                    txt_lon_hon_gia = tam.Rows[i].Field<long>(4) > long.Parse(txt_cp_gd.Text);

                    if (txt_lon_hon_gia & dau_cp)
                    {
                        dau_co_phieu = true;
                    }
                    else
                    {
                        dau_co_phieu = false;
                    }
                }

                if (CommonFormFunctions.Kiểm_tra_trung(txt_search.Text.Trim(), tam.Rows[i].Field<string>(3)) == false)
                    txt = false;
                else
                    txt = true;
                if (txt & dau_co_phieu)
                {
                    if (History_table.Rows[i].Visible == false)
                        try
                        {
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[History_table.DataSource];
                            currencyManager1.SuspendBinding();
                            History_table.Rows[i].Visible = true;
                            currencyManager1.ResumeBinding();
                        }
                        catch
                        {
                        }
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[History_table.DataSource];
                    currencyManager1.SuspendBinding();
                    History_table.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }
    }
}
