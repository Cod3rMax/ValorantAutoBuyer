using System;
using System.IO;
using System.Reflection;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ValorantAutoBuyer.FirstRoundOperations;

public class CheckFirstRound
{


    public static void CheckIfFirstRound()
    {
        var hWind = Helper.ValorantWindow.FindWindow(IntPtr.Zero, "VALORANT  ");
        Helper.ValorantWindow.GetWindowRect(hWind, out Helper.ValorantWindow._rect);
        
        FirstRoundOperations.ImageVariables.ValorantImage = new Mat(new OpenCvSharp.Size(Helper.ValorantScreenShot.TakeValorantScreenShot().Width, Helper.ValorantScreenShot.TakeValorantScreenShot().Height), MatType.CV_8UC3);
        
        while (true)
        {
            // Keep taking screenshots of the game
            BitmapConverter.ToMat(Helper.ValorantScreenShot.TakeValorantScreenShot(), FirstRoundOperations.ImageVariables.ValorantImage);
            
            // Make the necessary operations on the original image
            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage);
            
            
            
            
            Cv2.ImShow("Original Source", FirstRoundOperations.ImageVariables.MaskValorantImageBitOperationResult);

            Cv2.WaitKey(10);
               
               
            GC.Collect();
        }
        
        
    }
}