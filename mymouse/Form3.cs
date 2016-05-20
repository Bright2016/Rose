using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace mymouse
{
    public partial class Form3 : Form
    {
        ///
        /// 获取指定窗口的设备场景
        ///
        /// 将获取其设备场景的窗口的句柄。若为0，则要获取整个屏幕的DC
        /// 指定窗口的设备场景句柄，出错则为0
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        ///
        /// 释放由调用GetDC函数获取的指定设备场景
        ///
        /// 要释放的设备场景相关的窗口句柄
        /// 要释放的设备场景句柄
        /// 执行成功为1，否则为0
        [DllImport("user32.dll")]
        public static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);
        ///
        /// 在指定的设备场景中取得一个像素的RGB值
        ///
        /// 一个设备场景的句柄
        /// 逻辑坐标中要检查的横坐标
        /// 逻辑坐标中要检查的纵坐标
        /// 指定点的颜色
        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);
        public Color GetColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero); uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF), (int)(pixel & 0x0000FF00) >> 8, (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Timer tim = new Timer();
            tim.Interval = 1;
            tim.Tick += delegate
            {
                pictureBox1.BackColor = GetColor(MousePosition.X, MousePosition.Y);
            };
            tim.Start();
        }
    }
}
