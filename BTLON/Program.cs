using BTLON.Prototype_Forms;
using BTLON.Prototype_Forms.ChildForms;
using System;
using System.Windows.Forms;

namespace BTLON
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SQL_Command_Testing());
            //Application.Run(new Log_In());
            // Application.Run(new Hiển_Thị_Các_Công_Ty());
            //Application.Run(new Vẽ_biểu_đồ());
            //Application.Run(Kho.màn_Hình_Tổng = new Màn_hình_tổng());
            Application.Run(GlobalVariable.global_thử_Nghiệm_Main_Menu);
        }
    }
}
