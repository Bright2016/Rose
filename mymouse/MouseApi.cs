using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace mymouse
{

    //const int MOUSEEVENTF_MOVE = 0x0001;      移动鼠标 
    //const int MOUSEEVENTF_LEFTDOWN = 0x0002; 模拟鼠标左键按下 
    //const int MOUSEEVENTF_LEFTUP = 0x0004; 模拟鼠标左键抬起 
    //const int MOUSEEVENTF_RIGHTDOWN = 0x0008; 模拟鼠标右键按下 
    //const int MOUSEEVENTF_RIGHTUP = 0x0010; 模拟鼠标右键抬起 
    //const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; 模拟鼠标中键按下 
    //const int MOUSEEVENTF_MIDDLEUP = 0x0040; 模拟鼠标中键抬起 
    //const int MOUSEEVENTF_ABSOLUTE = 0x8000; 标示是否采用绝对坐标


    public class MouseApi
    {
        [DllImport("User32.dll")]
        static extern void mouse_event(MouseEventFlag flags, int dx, int dy, uint data, UIntPtr extraInfo);
        [Flags]
        enum MouseEventFlag : uint
        {
            Move = 0x001, LeftDown = 0x0002, LeftUP = 0x0004, RightDown = 0x0008,
            RightUp = 0x0010, MiddleDown = 0x0020, MiddleUP = 0x0040, Absolut = 0x8000, xDown = 0x0080, xUp = 0x0100, wheel = 0x0800, virtualDesk = 0x4000
        }
        public void LeftClick()
        {
            mouse_event(MouseEventFlag.LeftUP, 500, 400, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.LeftDown, 500, 400, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.LeftUP, 500, 400, 0, UIntPtr.Zero);
        }
        public void RightClick()
        {
            mouse_event(MouseEventFlag.RightUp, 500, 400, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.RightDown, 500, 400, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.RightUp, 500, 400, 0, UIntPtr.Zero);
        }
        public void MiddleClick()
        {
            mouse_event(MouseEventFlag.MiddleUP, 500, 400, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.MiddleDown, 500, 400, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.MiddleUP, 500, 400, 0, UIntPtr.Zero);
        }

    }
}
