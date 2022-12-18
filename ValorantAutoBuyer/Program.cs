using System;
using System.Drawing;
using OpenCvSharp;

namespace ValorantAutoBuyer
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Mat ValorantImage = new Mat(@"C:\Users\User\Desktop\main.png");
            Cv2.ImShow("ValorantImage", ValorantImage);
            Cv2.WaitKey();
            Cv2.DestroyAllWindows();

            // Functions.CheckValorantGame.CheckGameOpenedThread.Start();
        }
        
    }
}