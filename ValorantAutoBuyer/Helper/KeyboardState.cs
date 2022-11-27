using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ValorantAutoBuyer.Helper
{
    public class KeyboardState
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern short GetAsyncKeyState(Keys xkey);
    }
}