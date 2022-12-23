using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using ValorantAutoBuyer.Helper;
using Point = System.Drawing.Point;

namespace ValorantAutoBuyer
{
    internal class Program
    {

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        public static void Main(string[] args)
        {
            // Console.WriteLine(IsIconic(Helper.ValorantWindow.FindWindow(IntPtr.Zero, "VALORANT  ")));
            // while (true)
            // {
            //     if (GetForegroundWindow() == ValorantWindow.FindWindow(IntPtr.Zero, "VALORANT  "))
            //     {
            //         Console.WriteLine("Valorant is active");
            //     }
            //     else
            //     {
            //         Console.WriteLine("valorant is not active");
            //     }
            //     Thread.Sleep(4000);
            // }
            // FirstRoundOperations.CheckFirstRound.CheckIfFirstRound();
            Functions.CheckValorantGame.CheckGameOpenedThread.Start();
        }
        
    }
}