using System.Runtime.InteropServices;

namespace ValorantAutoBuyer.Helper
{
    public class CursorPosition
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCursorPos(int x, int y);
    }
}