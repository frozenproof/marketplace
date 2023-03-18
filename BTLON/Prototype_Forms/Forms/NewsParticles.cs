using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BTLON.Prototype_Forms.Forms
{
    public partial class NewsParticles : Form
    {
        public NewsParticles()
        {
            InitializeComponent();
        }

        private void NewsParticles_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(panel3,true);
        }

        private void back_web_Click(object sender, EventArgs e)
        {
            news.GoBack();
        }

        private void forward_web_Click(object sender, EventArgs e)
        {
            news.GoForward();
        }

        private void reload_web_Click(object sender, EventArgs e)
        {
            news.Refresh();
        }
        //Drag Form

    }
}
