using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BTLON.Prototype_Forms
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        private Color primary_color;
        private Color text_color;
        private int arrow_thickness;
        public MenuRenderer(bool IsMainMenu, Color primary_color, Color text_color) : base(new MenuColorTable(IsMainMenu, primary_color))
        {
            this.primary_color = primary_color;
            //MessageBox.Show(this.primary_color.ToString());
            this.text_color = text_color;
            if (IsMainMenu)
                arrow_thickness = 3;
            else
                arrow_thickness = 2;
        }
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : primary_color;
            //e.Item.ForeColor = Color.Purple;
        }
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderMenuItemBackground(e);
            //e.Item.BackColor = e.Item.Selected ?  Color.Black : Color.White ;
            //if (e.Item.Selected)
            //{
            //    e.Item.BackColor = Color.Black;
            //    //MessageBox.Show("Bruh");
            //}
            //else
            //{
            //    e.Item.BackColor = Color.White;
            //}
            e.Item.BackColor = Color.Black;
        }
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            //base.OnRenderArrow(e);
            var graph = e.Graphics;
            var arrow_size = new Size(5, 12);
            var arrow_color = e.Item.Selected ? Color.Purple : primary_color;
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height - arrow_size.Height) / 2, arrow_size.Width, arrow_size.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrow_color, arrow_thickness))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                //path.AddLine(rect.Left, rect.Top, rect.Bottom, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height);
                graph.DrawPath(pen, path);
            }
        }

    }
}
