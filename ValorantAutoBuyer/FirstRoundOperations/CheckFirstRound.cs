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

        FirstRoundOperations.ImageVariables.ValorantImage = new Mat(
            new OpenCvSharp.Size(Helper.ValorantScreenShot.TakeValorantScreenShot().Width,
                Helper.ValorantScreenShot.TakeValorantScreenShot().Height), MatType.CV_8UC3);

        while (true)
        {
            // Keep taking screenshots of the game
            BitmapConverter.ToMat(Helper.ValorantScreenShot.TakeValorantScreenShot(),
                FirstRoundOperations.ImageVariables.ValorantImage);


            //// Get the match test
            // FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
            //     FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
            //     FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.NeedleImage1)
            // );

            // Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
            // if (FirstRoundOperations.ImageVariables.maxVal > 0.82)
            // {
            //     Console.WriteLine("First game started with first needle");
            //     break;
            // }

            // FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
            //     FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
            //     FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.NeedleImage2)
            // );

            // Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
            // if (FirstRoundOperations.ImageVariables.maxVal > 0.84)
            // {
            //     Console.WriteLine("First game started with second needle");
            //     break;
            // }


            // FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
            //     FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations.ImageVariables.ValorantImage),
            //     FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.NeedleImage3)
            // );

            // Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
            // if (FirstRoundOperations.ImageVariables.maxVal > 0.84)
            // {
            //     Console.WriteLine("First game started with third needle");
            //     break;
            // }


            // Now we start with FirstRoundOfHalf Needle

            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations
                    .ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables
                    .FirstRoundOfHalf1)
            );

            Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf1");
                Thread.Sleep(6000);
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations
                    .ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables
                    .FirstRoundOfHalf2)
            );

            Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf2");
                Thread.Sleep(6000);
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations
                    .ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables
                    .FirstRoundOfHalf3)
            );

            Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf3");
                Thread.Sleep(6000);
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations
                    .ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables
                    .FirstRoundOfHalf4)
            );

            Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf4");
                Thread.Sleep(6000);
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations
                    .ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables
                    .FirstRoundOfHalf5)
            );

            Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf5");
                Thread.Sleep(6000);
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations
                    .ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables
                    .FirstRoundOfHalf6)
            );

            Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf6");
                Thread.Sleep(6000);
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations
                    .ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables
                    .FirstRoundOfHalf7)
            );

            Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf7");
                Thread.Sleep(6000);
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations
                    .ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables
                    .FirstRoundOfHalf8)
            );

            Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf8");
                Thread.Sleep(6000);
            }


            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(FirstRoundOperations
                    .ImageVariables.ValorantImage),
                FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables
                    .FirstRoundOfHalf9)
            );

            Console.WriteLine(FirstRoundOperations.ImageVariables.maxVal);
            if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
            {
                Console.WriteLine("First game started with FirstRoundOfHalf9");
                Thread.Sleep(6000);
            }

            Cv2.ImShow("Original Source", FirstRoundOperations.ImageVariables.ValorantImage);
            Cv2.WaitKey(10);
            GC.Collect();
        }
    }
}