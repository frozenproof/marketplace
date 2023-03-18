using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace BTLON.Prototype_Forms
{
    public class CustomDropDownMenu : ContextMenuStrip
    {
        private bool isMainMenu;
        private int menu_item_height = 25;
        //private Color menu_item_text_color = Color.DimGray;
        private Color menu_item_text_color = Color.DimGray;
        //private Color primary_color = Color.MediumSlateBlue;
        private Color primary_color = Color.Red;

        private Bitmap menu_item_header_size;

        //ham tao, vo cung dac biet vi cach thiet ke nay cho phep dispose chung voi cha no
        public CustomDropDownMenu(IContainer container) : base(container)
        {

        }

        [Browsable(false)]
        public bool IsMainMenu { get => isMainMenu; set => isMainMenu = value; }

        [Browsable(false)]
        public int Menu_item_height { get => menu_item_height; set => menu_item_height = value; }

        [Browsable(false)]
        public Color Menu_item_text_color { get => menu_item_text_color; set => menu_item_text_color = value; }

        [Browsable(false)]
        public Color Primary_color { get => primary_color; set => primary_color = value; }

        //
        private void Load_menu_item_appearance()
        {
            if (isMainMenu)
            {
                menu_item_header_size = new Bitmap(25, 45);
                menu_item_text_color = Color.Gainsboro;
            }
            else
            {
                menu_item_header_size = new Bitmap(15, menu_item_height);
            }
            foreach (ToolStripMenuItem menu_item_lvl_1 in this.Items)
            {
                menu_item_lvl_1.ForeColor = menu_item_text_color;
                menu_item_lvl_1.ImageScaling = ToolStripItemImageScaling.None;
                if (menu_item_lvl_1.Image == null) menu_item_lvl_1.Image = menu_item_header_size;
                foreach (ToolStripMenuItem menu_item_lvl_2 in menu_item_lvl_1.DropDownItems)
                {
                    menu_item_lvl_2.ForeColor = menu_item_text_color;
                    menu_item_lvl_2.ImageScaling = ToolStripItemImageScaling.None;
                    if (menu_item_lvl_2.Image == null) menu_item_lvl_2.Image = menu_item_header_size;
                    foreach (ToolStripMenuItem menu_item_lvl_3 in menu_item_lvl_2.DropDownItems)
                    {
                        menu_item_lvl_3.ForeColor = menu_item_text_color;
                        menu_item_lvl_3.ImageScaling = ToolStripItemImageScaling.None;
                        if (menu_item_lvl_3.Image == null) menu_item_lvl_3.Image = menu_item_header_size;
                        foreach (ToolStripMenuItem menu_item_lvl_4 in menu_item_lvl_3.DropDownItems)
                        {
                            menu_item_lvl_4.ForeColor = menu_item_text_color;
                            menu_item_lvl_4.ImageScaling = ToolStripItemImageScaling.None;
                            if (menu_item_lvl_4.Image == null) menu_item_lvl_4.Image = menu_item_header_size;
                        }
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            //bug , color does not register
            primary_color = Color.Red;
            //menu_item_text_color = Color.White;
            if (this.DesignMode==false)
            {
                //MessageBox.Show("Current start color: "+primary_color);
                //MessageBox.Show("Current start color: " + menu_item_text_color);
                Load_menu_item_appearance();
                this.Renderer = new MenuRenderer(IsMainMenu,primary_color,menu_item_text_color);
            }
        }
    }
}
