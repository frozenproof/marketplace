using System;
using System.Windows.Forms;

namespace BTLON.Prototype_Forms.ChildForms
{
    public partial class Default_Home_Screen : Form
    {
        public Default_Home_Screen()
        {
            InitializeComponent();
        }

        private void Đồng_hồ_Tick(object sender, EventArgs e)
        {
          label_time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
