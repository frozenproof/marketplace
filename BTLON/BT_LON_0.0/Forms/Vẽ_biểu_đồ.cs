using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON.Forms
{
    public partial class Vẽ_biểu_đồ : Form
    {
        public Vẽ_biểu_đồ()
        {
            InitializeComponent();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100001;
            int i = 0;
            progressBar1.Value = 0;
            while (i<100000)
            {
                i++; progressBar1.Value += 1;
            }
        }
    }
}
