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

            // Jett
                // int width = (Helper.ValorantWindow._rect.Right - Helper.ValorantWindow._rect.Left) / 2;
                // int height = (Helper.ValorantWindow._rect.Buttom - Helper.ValorantWindow._rect.Top) / 2;
                // Helper.CursorPosition.SetCursorPos((width / 2) + (width / 4) + (width / 3) + (width / 8), height + height - (height / 4) - 30);
            
                
                // Kayo
                // int width = (Helper.ValorantWindow._rect.Right - Helper.ValorantWindow._rect.Left) / 2;
                // int height = (Helper.ValorantWindow._rect.Buttom - Helper.ValorantWindow._rect.Top) / 2;
                // Helper.CursorPosition.SetCursorPos((width / 2) + (width / 4) + (width / 3) + (width / 5 + 10), height + height - (height / 4) - 30);
                
                
                // killjoy
                // int width = (Helper.ValorantWindow._rect.Right - Helper.ValorantWindow._rect.Left) / 2;
                // int height = (Helper.ValorantWindow._rect.Buttom - Helper.ValorantWindow._rect.Top) / 2;
                // Helper.CursorPosition.SetCursorPos((width / 2) + (width / 4) + (width / 3) + (width / 3 - 15), height + height - (height / 4) - 30);


                Functions.CheckValorantGame.CheckGameOpenedThread.Start();

        }

    }
}