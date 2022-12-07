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

            Functions.CheckValorantGame.CheckGameOpenedThread.Start();

        }

    }
}