using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using Point = System.Drawing.Point;

namespace ValorantAutoBuyer
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            // FirstRoundOperations.CheckFirstRound.CheckIfFirstRound();
            Functions.CheckValorantGame.CheckGameOpenedThread.Start();
        }
        
    }
}