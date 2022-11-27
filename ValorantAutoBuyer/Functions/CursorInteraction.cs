using System;

namespace ValorantAutoBuyer.Functions
{
    public class CursorInteraction
    {
        public static void CursorClick()
        {
            Helper.MouseMovment.mouse_event(Globals.Const.MOUSEEVENTF_LEFTDOWN,0,0,0,IntPtr.Zero);
            Helper.MouseMovment.mouse_event(Globals.Const.MOUSEEVENTF_LEFTUP,0,0,0,IntPtr.Zero);
        }
    }
}