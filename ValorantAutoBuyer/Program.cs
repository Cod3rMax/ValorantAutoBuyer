using System;
using System.Drawing;

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