using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BTLON.Prototype_Forms.ChildForms.Giao_dich.Tien;
using BTLON.Prototype_Forms.ChildForms.Theo_doi;
using BTLON.Prototype_Forms.ChildForms.Theo_doi.Views;
using BTLON.Prototype_Forms.Forms;

namespace BTLON.Prototype_Forms.ChildForms
{
    public partial class Thử_nghiệm_Main_menu : Form
    {
        private Button current_button;
        private Random random = new Random();
        private Form Current_child_form;
        public int temp_index;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
        private int borderSize = 2;
        public static string m_kh = "";


        private Color color_picking()
        {
            int index = random.Next(ThemeColor.color_list.Count);
            Color temp_color;
            //randomly picking an color and random again if got the previous color
            while (temp_index == index)
            {
                /* index = */
                random.Next(ThemeColor.color_list.Count);
            }
            temp_index = index;
            string color = ThemeColor.color_list[index];
            try
            {
                temp_color = ColorTranslator.FromHtml(color);
            }
            catch
            {
                MessageBox.Show("Broken Color");
                temp_color = ColorTranslator.FromHtml(color);
            }
            return temp_color;
        }
        private string color_string_picking()
        {
            int index = random.Next(ThemeColor.color_list.Count - 1);
            //randomly picking an color and random again if got the previous color
            while (temp_index == index)
            {
                index = random.Next(ThemeColor.color_name_list.Count - 1);
            }
            temp_index = index;
            if (temp_index == 0)
            {
                temp_index++;
                index++;
            }
            string color = ThemeColor.color_name_list[index - 1];
            return color;
        }

        public Thử_nghiệm_Main_menu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            //need checking later with jdn
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
         }

        private void Thử_nghiệm_Load(object sender, EventArgs e)
        {
            Open_child_form(new Đăng_Nhập());
            btn_giao_dịch.Enabled = btn_giao_dịch.Visible = false;
            btn_theo_dõi.Enabled = btn_theo_dõi.Visible = false;
            btn_lich_su.Enabled = btn_lich_su.Visible = false;
            btn_tài_khoản.Enabled = btn_tài_khoản.Visible = false;
            btn_biểu_đồ.Enabled = btn_biểu_đồ.Visible = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            formSize = this.ClientSize;

        }


        public void ActivateMenuTN()
        {
            btn_giao_dịch.Enabled = btn_giao_dịch.Visible = true;
            btn_theo_dõi.Enabled = btn_theo_dõi.Visible = true;
            btn_lich_su.Enabled = btn_lich_su.Visible = true;
            btn_tài_khoản.Enabled = btn_tài_khoản.Visible = true;
            btn_biểu_đồ.Enabled = btn_biểu_đồ.Visible = true;
            btn_đăng_nhập.Enabled = btn_đăng_nhập.Visible = false;
            this.Refresh();
            Open_child_form(new NewsParticles());
        }
        private void Activate_button(object btn_sender)
        {
            if (btn_sender != null)
            {
                if (current_button != (Button)btn_sender)
                {
                    //MessageBox.Show("D");
                    Disable_Button();
                    //MessageBox.Show("D2");
                    //Color color = Color.FromName(color_picking().ToString());
                    //Color color = Color.FromName(color_string_picking());
                    Color color = Color.FromArgb(193, 21, 21);
                    //MessageBox.Show("D3");
                    current_button = (Button)btn_sender;
                    current_button.BackColor = color;
                    current_button.ForeColor = Color.Beige;
                    current_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    current_icon_panel.BackgroundImage = current_button.Image;
                    title_of_child_form.Text = current_button.Text;

                }
            }
        }
        private void Disable_Button()
        {
            foreach (Control previoius_btn in panel_menu.Controls)
            {
                if (previoius_btn.GetType() == typeof(Button))
                {
                    //previoius_btn.BackColor = Color.FromArgb(67, 29, 86);
                    //previoius_btn.BackColor = Color.FromArgb(255, 255, 255);
                    previoius_btn.BackColor = Color.FromArgb(0, 0, 0);
                    previoius_btn.ForeColor = Color.White;
                    previoius_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void Open_child_form(Form Child_form)
        {
            if (Current_child_form != null)
            {
                Current_child_form.Close();
            }
            Current_child_form = Child_form;
            Child_form.TopLevel = false;
            Child_form.FormBorderStyle = FormBorderStyle.None;
            Child_form.Dock = DockStyle.Fill;
            panel_desktop.Controls.Add(Child_form);
            panel_desktop.Tag = Child_form;
            Child_form.BringToFront();
            Child_form.Show();
        }
        private void Reset()
        {
            Disable_Button();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Windows_Controls_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel_child_title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Gỡ trong suốt
        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        private void Close_button_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void btn_lich_su_Click(object sender, EventArgs e)
        {
            Activate_button(sender);
            Open_child_form(new Lich_su.Lich_su());
        }


        private void btn_giao_dịch_Click(object sender, EventArgs e)
        {
            Activate_button(sender);
            Trading_Main_DropDown.Show(btn_giao_dịch, btn_giao_dịch.Width, 0);
            //Open_child_form(new Giao_dịch_01());
        }
        private void btn_theo_dõi_Click(object sender, EventArgs e)
        {
            Activate_button(sender);
            Open_child_form(new TheoDoi());
        }


        private void btn_tài_khoản_Click(object sender, EventArgs e)
        {
            Activate_button(sender);
            Open_child_form(new Account());
            Account_Main_DropDown.Show(btn_tài_khoản, btn_tài_khoản.Width, 0);
        }


        private void logo_Click(object sender, EventArgs e)
        {
            Reset();
            Current_child_form.Close();
            Open_child_form(new NewsParticles());
            title_of_child_form.Text = "Home";
            title_of_child_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //current_icon_panel.BackgroundImage = ;
            this.Refresh();
        }

        private void Thử_nghiệm_Main_menu_Resize(object sender, EventArgs e)
        {
            AdjustForm();
            this.Refresh();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 0, 0, 0);
                    break;
                case FormWindowState.Normal:
                    this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void Thử_nghiệm_Main_menu_Enter(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thử_nghiệm_Load(sender,e);
        }

        private void nạpTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_child_form(new NapTien());
            this.Refresh();
        }

        private void btn_biểu_đồ_Click(object sender, EventArgs e)
        {
            Activate_button(sender);
            this.Refresh();
            Open_child_form(new Graph.Graphes());
            this.Refresh();
        }

        private void btn_đăng_nhập_Click(object sender, EventArgs e)
        {
            Open_child_form(new Đăng_Nhập());
            this.Refresh();
        }

        private void muaBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_child_form(new CompanyView());
            this.Refresh();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Open_child_form(new CompanyView());
            this.Refresh();
        }

        private void rútTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_child_form(new RutTien());
            this.Refresh();
        }

        private void chuyểnTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_child_form(new ChuyenTien());
            this.Refresh();

        }
    }
}
