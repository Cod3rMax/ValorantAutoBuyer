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
            
            
            // Get the match test
             FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                 FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                 FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.NeedleImage1)
             );
             
             Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
             if (FirstRoundOperations.ImageVariables.maxVal > 0.82)
             {
                 Console.WriteLine("First game started with first needle");
                 break;
             }
             
             FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                 FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                 FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.NeedleImage2)
             );
             
             Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
             if (FirstRoundOperations.ImageVariables.maxVal > 0.84)
             {
                 Console.WriteLine("First game started with second needle");
                 break;
             }

             
             
             FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                 FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                 FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.NeedleImage3)
             );
             
             Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
             if (FirstRoundOperations.ImageVariables.maxVal > 0.84)
             {
                 Console.WriteLine("First game started with third needle");
                 break;
             }

             
             
             
            Cv2.ImShow("Original Source", FirstRoundOperations.ImageVariables.ValorantImage);
            Cv2.WaitKey(10);
            GC.Collect();
        }
        
        
    }
}