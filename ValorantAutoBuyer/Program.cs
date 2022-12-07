using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using ValorantAutoBuyer.Helper;
using WindowsInput;
using WindowsInput.Native;

namespace ValorantAutoBuyer
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            //Brimstone position

            //var hWind = Helper.ValorantWindow.FindWindow(IntPtr.Zero, "VALORANT  ");
            //Helper.ValorantWindow.GetWindowRect(hWind, out Helper.ValorantWindow._rect);
            //int width = (Helper.ValorantWindow._rect.Right - Helper.ValorantWindow._rect.Left) / 2;
            //int height = (Helper.ValorantWindow._rect.Buttom - Helper.ValorantWindow._rect.Top) / 2;
            //Helper.CursorPosition.SetCursorPos((width / 2) + (width / 4) + 40, height + height - (height / 4) - 30);





            Functions.CheckValorantGame.CheckGameOpenedThread.Start();


        }

    }
}