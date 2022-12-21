using System;
using System.IO;
using System.Reflection;
using System.Threading;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ValorantAutoBuyer.FirstRoundOperations;

public class CheckFirstRound
{
    public static void CheckIfFirstRound()
    {
        var hWind = Helper.ValorantWindow.FindWindow(IntPtr.Zero, "VALORANT  ");
        Helper.ValorantWindow.GetWindowRect(hWind, out Helper.ValorantWindow._rect);

        FirstRoundOperations.ImageVariables.ValorantImage = new Mat
        (
            new OpenCvSharp.Size(Helper.ValorantScreenShot.TakeValorantScreenShot().Width, 
           Helper.ValorantScreenShot.TakeValorantScreenShot().Height), MatType.CV_8UC3
        );

        while (true)
        {
            // Keep taking screenshots of the game
            BitmapConverter.ToMat(Helper.ValorantScreenShot.TakeValorantScreenShot(), FirstRoundOperations.ImageVariables.ValorantImage);


            // Get the match test
             FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
             (
                 FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage), 
                 FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.NeedleImage1)
             );
             
             
             if (FirstRoundOperations.ImageVariables.maxVal > 0.82)
             {
                 Console.WriteLine("First game started with first needle");
             }

             
             FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
             (
                 FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                 FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.NeedleImage2)
             );
             
             if (FirstRoundOperations.ImageVariables.maxVal > 0.84)
             {
                 Console.WriteLine("First game started with second needle");
             }


             FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
             (
                 FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                 FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.NeedleImage3)
             );

           
             if (FirstRoundOperations.ImageVariables.maxVal > 0.84)
             {
                 Console.WriteLine("First game started with third needle");
             }


            // Now we start with FirstRoundOfHalf Needle

            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
            (
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf1)
            );


            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf1");
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
            (
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf2)
            );

 
            
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf2");
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
            (
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf3)
            );

           
            
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf3");
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
            (
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf4)
            );

            
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf4");
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
            (
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf5)
            );

            
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf5");
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
            (
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf6)
            );

            
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf6");
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
            (
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf7)
            );

           
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf7");
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf8)
            );

            
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf8");
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
            (
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf9)
            );

            
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf9");
            }

            Cv2.ImShow("Original Source", FirstRoundOperations.ImageVariables.ValorantImage);
            Cv2.WaitKey(10);
            GC.Collect();
        }
    }
}