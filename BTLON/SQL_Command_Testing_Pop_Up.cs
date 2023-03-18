using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON
{
    public partial class SQL_Command_Testing_Pop_Up : Form
    {
        public SQL_Command_Testing_Pop_Up()
        {
            InitializeComponent();
        }

        private void SQL_Command_Testing_Pop_Up_Load(object sender, EventArgs e)
        {

        }

        public void setTable(DataTable temporary)
        {
            Table_SQL.DataSource = temporary;
            return;
        }
    }
}
