using System;
using System.Runtime.InteropServices;

namespace ValorantAutoBuyer.Helper
{
    public class ValorantWindow
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(IntPtr lpClassName, string lpWindowName);
        
        [DllImport("user32.dll", SetLastError=true)]
        public static extern bool GetWindowRect(IntPtr hwnd, out Rect lpRect);
        
        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int Left, Top, Right, Buttom;
        }
        public static Rect _rect;
    }
}