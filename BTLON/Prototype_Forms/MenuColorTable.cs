using System.Windows.Forms;
using System.Drawing;

namespace BTLON.Prototype_Forms
{
    public class MenuColorTable : ProfessionalColorTable
    {
        //fields colors
        private Color back_color;
        private Color Left_column_color;
        private Color border_color;
        private Color menu_item_border_color;
        private Color menu_item_selected_color;
        public MenuColorTable(bool isMainMenu, Color primary_color)
        {
            //if (isMainMenu)
            //{
            //    back_color = Color.FromArgb(37, 39, 49);
            //    Left_column_color = Color.FromArgb(32, 32, 32);
            //    border_color = Color.FromArgb(32, 31, 92);
            //    menu_item_border_color = primary_color;
            //    menu_item_selected_color = primary_color;
            //}
            //else
            //{
                back_color = Color.Black;
                Left_column_color = Color.Black;
                border_color = Color.Black;
                //MessageBox.Show(primary_color.ToString());
                menu_item_border_color = primary_color;
                menu_item_selected_color = primary_color;
            //}
        }
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return back_color;
            }
        }
        public override Color MenuBorder
        {
            get
            {
                return border_color;
            }
        }
        public override Color MenuItemSelected
        {
            get
            {
                return menu_item_selected_color;
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return menu_item_border_color;
            }
        }
        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Left_column_color;
            }
        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Left_column_color;
            }
        }
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Left_column_color;
            }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.Black; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.Black; }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.Black;
            }
        }
        public override Color MenuItemPressedGradientEnd 
        {
            get
            {
                return Color.Black;
            }
        }
    }
}
