using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace mymouse
{

    public partial class Form1 : Form
    {
        [DllImport("User32")]
        public extern static void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);

        [DllImport("User32")]
        public extern static void SetCursorPos(int x, int y);

        [DllImport("User32")]
        public extern static bool GetCursorPos(out POINT p);

        [DllImport("User32")]
        public extern static int ShowCursor(bool bShow);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }

        [Flags]
        public enum MouseEventFlags
        {
            Move = 0x0001,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            Wheel = 0x0800,
            Absolute = 0x8000
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Test1_Click(object sender, EventArgs e)
        {
            int dx = 10 * 65535 / Screen.PrimaryScreen.Bounds.Width;
            int dy = 10 * 65535 / Screen.PrimaryScreen.Bounds.Height;

            mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.Absolute), dx, dy, 0, IntPtr.Zero);
            mouse_event((int)(MouseEventFlags.LeftUp | MouseEventFlags.Absolute), dx, dy, 0, IntPtr.Zero);
        }

        private void Test2_Click(object sender, EventArgs e)
        {
            POINT p = new POINT();
            GetCursorPos(out p);

            try
            {
                ShowCursor(false);
                SetCursorPos(10, 10);

                mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.Absolute), 0, 0, 0, IntPtr.Zero);
                mouse_event((int)(MouseEventFlags.LeftUp | MouseEventFlags.Absolute), 0, 0, 0, IntPtr.Zero);
            }
            finally
            {
                SetCursorPos(p.X, p.Y);
                ShowCursor(true);
            }
        }
    }
    
    //public partial class Form1 : Form
    //{
    //    MouseApi mouseApiNew = new MouseApi();

    //    public Form1()
    //    {
    //        InitializeComponent();
    //    }

    //    private void Form1_Load(object sender, EventArgs e)
    //    {

    //    }

    //    private void btnright_Click(object sender, EventArgs e)
    //    {
    //        mouseApiNew.RightClick();
    //    }

    //    private void btnmid_Click(object sender, EventArgs e)
    //    {
    //        mouseApiNew.MiddleClick();

    //    }

    //    private void btnleft_Click(object sender, EventArgs e)
    //    {
    //        mouseApiNew.LeftClick();
    //    }

    //}
}
