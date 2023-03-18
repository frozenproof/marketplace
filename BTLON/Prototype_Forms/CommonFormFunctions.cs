using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON.Prototype_Forms
{
    public class CommonFormFunctions
    {
        public static bool Check_Empty(string target)
        {
            if (string.IsNullOrEmpty(target))
            {
                return true;
            }
            return false;
        }
        public static bool isNumber(string e)
        {
            var regex = new Regex(@"[^0-9\s]");
            if (!regex.IsMatch(e))
            {
                return false;
            }
            return true;
        }
        public static bool Kiểm_tra_trung(string thu, string mau)
        {
            var regex = new Regex(thu);
            if (regex.IsMatch(mau))
            {
                return true;
            }
            return false;
        }

        public static void thêm_cột_vào_bảng(DataTable current, string[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                DataColumn temp = new DataColumn(name[i]);
                try
                {
                    current.Columns.Add(temp);
                }
                catch
                {
                }
            }
        }

    }
}
