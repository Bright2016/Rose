using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace testcom
{
    public partial class move : Form
    {

        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_STYLE = (-16);
        private const int GWL_EXSTYLE = (-20);
        private const int LWA_ALPHA = 0x2;

        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(
        IntPtr hwnd,
        int nIndex,
        uint dwNewLong
        );



        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(
        IntPtr hwnd,
        int nIndex
        );



        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern int SetLayeredWindowAttributes(
        IntPtr hwnd,
        int crKey,
        int bAlpha,
        int dwFlags
        );



        ///<summary>
        /// 设置窗体具有鼠标穿透效果
        ///</summary>
        public void SetPenetrate()
        {
            this.TopMost = true;
            GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
            SetLayeredWindowAttributes(this.Handle, 0, 100, LWA_ALPHA);

        }


        public move()
        {
            InitializeComponent();
        }
        private int x;
        private int y;
        bool bMove = false;

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMove)
            {
                button1.Location = new Point(button1.Left + e.X - x, button1.Top + e.Y - y);
            }

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bMove = true;
                x = e.X;
                y = e.Y;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bMove = false;
                x = e.X;
                y = e.Y;
            }

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMove)
            {
                button2.Location = new Point(button2.Left + e.X - x, button2.Top + e.Y - y);
            }
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMove)
            {
                button3.Location = new Point(button3.Left + e.X - x, button3.Top + e.Y - y);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetPenetrate();
        }

    }

}
