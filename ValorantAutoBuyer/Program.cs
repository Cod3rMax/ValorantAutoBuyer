using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ValorantAutoBuyer.Helper;
using WindowsInput;
using WindowsInput.Native;

namespace ValorantAutoBuyer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Display.Header.ValorantAutoBuyerHeader();
            Functions.CheckUserInput.StartAutoBuyer();
        }
        
    }
}