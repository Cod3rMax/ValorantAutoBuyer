using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Input;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using ValorantAutoBuyer.Helper;
using Point = System.Drawing.Point;

namespace ValorantAutoBuyer
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            FirstRoundOperations.CheckFirstRound.CheckIfFirstRound();
            // Functions.CheckValorantGame.CheckGameOpenedThread.Start();
        }
        
    }
}