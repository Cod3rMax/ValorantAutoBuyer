using System;
using System.Runtime.InteropServices;

namespace ValorantAutoBuyer.Helper
{
    public class MouseMovment
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);
    }
}