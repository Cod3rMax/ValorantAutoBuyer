using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using ValorantAutoBuyer.Functions;

namespace ValorantAutoBuyer.FirstRoundOperations;

public class CheckFirstRound
{

    public static int SoundDuration = 200;
    
    public static void CheckIfFirstRound()
    {
        var hWind = Helper.ValorantWindow.FindWindow(IntPtr.Zero, "VALORANT  ");
        Helper.ValorantWindow.GetWindowRect(hWind, out Helper.ValorantWindow._rect);

        
        
        
        // Ask the user here if he wants to purchase all abilities on the first round.
        Colorful.Console.Write("[*] => Would you like to purchase all abilities on first round? (Y/N): ", Color.Orange);
        var FirstRoundUserAnswer = Colorful.Console.ReadLine();
        
        switch (FirstRoundUserAnswer)
        {
            case var _ when FirstRoundUserAnswer.ToString().ToLower() == "y" || FirstRoundUserAnswer.ToString().ToLower() == "yes":
                Globals.Config.CheckFirstRound = true;
                while (Globals.Config.CheckFirstRound)
                {
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
                            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(
                                FirstRoundOperations.ImageVariables.ValorantImage),
                            FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.NeedleImage1)
                        );


                        if (FirstRoundOperations.ImageVariables.maxVal > 0.82)
                        {
                            Console.WriteLine("First game started with first needle");
                            Console.Beep(1000, SoundDuration);
                            Console.Beep(1000, SoundDuration);
                            KeyboardInteraction.PressButtonB();
                            Thread.Sleep(20);
                            Purchase.Abilities.PurchaseAbilities();
                            Thread.Sleep(20);
                            KeyboardInteraction.PressButtonB();
                            Globals.Config.CheckFirstRound = false;
                            break;
                        }


                        FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
                        (
                            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(
                                FirstRoundOperations.ImageVariables.ValorantImage),
                            FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.NeedleImage2)
                        );

                        if (FirstRoundOperations.ImageVariables.maxVal > 0.84)
                        {
                            Console.WriteLine("First game started with second needle");
                            Console.Beep(1000, SoundDuration);
                            Console.Beep(1000, SoundDuration);
                            KeyboardInteraction.PressButtonB();
                            Thread.Sleep(20);
                            Purchase.Abilities.PurchaseAbilities();
                            Thread.Sleep(20);
                            KeyboardInteraction.PressButtonB();
                            Globals.Config.CheckFirstRound = false;
                            break;
                        }


                        FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
                        (
                            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(
                                FirstRoundOperations.ImageVariables.ValorantImage),
                            FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.NeedleImage3)
                        );


                        if (FirstRoundOperations.ImageVariables.maxVal > 0.84)
                        {
                            Console.WriteLine("First game started with third needle");
                            Console.Beep(1000, SoundDuration);
                            Console.Beep(1000, SoundDuration);
                            KeyboardInteraction.PressButtonB();
                            Thread.Sleep(20);
                            Purchase.Abilities.PurchaseAbilities();
                            Thread.Sleep(20);
                            KeyboardInteraction.PressButtonB();
                            Globals.Config.CheckFirstRound = false;
                            break;
                        }


                        // Now we start with FirstRoundOfHalf Needle

                        FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
                        (
                            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(
                                FirstRoundOperations.ImageVariables.ValorantImage),
                            FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf1)
                        );


                        if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
                        {
                            Console.WriteLine("First game started with FirstRoundOfHalf1");
                            Console.Beep(1000, SoundDuration);
                            Console.Beep(1000, SoundDuration);
                            KeyboardInteraction.PressButtonB();
                            Thread.Sleep(20);
                            Purchase.Abilities.PurchaseAbilities();
                            Thread.Sleep(20);
                            KeyboardInteraction.PressButtonB();
                            Globals.Config.CheckFirstRound = false;
                            break;
                        }


                        FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
                        (
                            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(
                                FirstRoundOperations.ImageVariables.ValorantImage),
                            FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf2)
                        );


                        if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
                        {
                            Console.WriteLine("First game started with FirstRoundOfHalf2");
                            Console.Beep(1000, SoundDuration);
                            Console.Beep(1000, SoundDuration);
                            KeyboardInteraction.PressButtonB();
                            Thread.Sleep(20);
                            Purchase.Abilities.PurchaseAbilities();
                            Thread.Sleep(20);
                            KeyboardInteraction.PressButtonB();
                            Globals.Config.CheckFirstRound = false;
                            break;
                        }


                        FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
                        (
                            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(
                                FirstRoundOperations.ImageVariables.ValorantImage),
                            FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf3)
                        );


                        if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
                        {
                            Console.WriteLine("First game started with FirstRoundOfHalf3");
                            Console.Beep(1000, SoundDuration);
                            Console.Beep(1000, SoundDuration);
                            KeyboardInteraction.PressButtonB();
                            Thread.Sleep(20);
                            Purchase.Abilities.PurchaseAbilities();
                            Thread.Sleep(20);
                            KeyboardInteraction.PressButtonB();
                            Globals.Config.CheckFirstRound = false;
                            break;
                        }


                        FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
                        (
                            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(
                                FirstRoundOperations.ImageVariables.ValorantImage),
                            FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf4)
                        );


                        if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
                        {
                            Console.WriteLine("First game started with FirstRoundOfHalf4");
                            Console.Beep(1000, SoundDuration);
                            Console.Beep(1000, SoundDuration);
                            KeyboardInteraction.PressButtonB();
                            Thread.Sleep(20);
                            Purchase.Abilities.PurchaseAbilities();
                            Thread.Sleep(20);
                            KeyboardInteraction.PressButtonB();
                            Globals.Config.CheckFirstRound = false;
                            break;
                        }


                        FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
                        (
                            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(
                                FirstRoundOperations.ImageVariables.ValorantImage),
                            FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf5)
                        );


                        if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
                        {
                            Console.WriteLine("First game started with FirstRoundOfHalf5");
                            Console.Beep(1000, SoundDuration);
                            Console.Beep(1000, SoundDuration);
                            KeyboardInteraction.PressButtonB();
                            Thread.Sleep(20);
                            Purchase.Abilities.PurchaseAbilities();
                            Thread.Sleep(20);
                            KeyboardInteraction.PressButtonB();
                            Globals.Config.CheckFirstRound = false;
                            break;
                        }


                        FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
                        (
                            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(
                                FirstRoundOperations.ImageVariables.ValorantImage),
                            FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf6)
                        );


                        if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
                        {
                            Console.WriteLine("First game started with FirstRoundOfHalf6");
                            Console.Beep(1000, SoundDuration);
                            Console.Beep(1000, SoundDuration);
                            KeyboardInteraction.PressButtonB();
                            Thread.Sleep(20);
                            Purchase.Abilities.PurchaseAbilities();
                            Thread.Sleep(20);
                            KeyboardInteraction.PressButtonB();
                            Globals.Config.CheckFirstRound = false;
                            break;
                        }


                        FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
                        (
                            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(
                                FirstRoundOperations.ImageVariables.ValorantImage),
                            FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf7)
                        );


                        if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
                        {
                            Console.WriteLine("First game started with FirstRoundOfHalf7");
                            Console.Beep(1000, SoundDuration);
                            Console.Beep(1000, SoundDuration);
                            KeyboardInteraction.PressButtonB();
                            Thread.Sleep(20);
                            Purchase.Abilities.PurchaseAbilities();
                            Thread.Sleep(20);
                            KeyboardInteraction.PressButtonB();
                            Globals.Config.CheckFirstRound = false;
                            break;
                        }


                        FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound(
                            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(
                                FirstRoundOperations.ImageVariables.ValorantImage),
                            FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf8)
                        );


                        if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
                        {
                            Console.WriteLine("First game started with FirstRoundOfHalf8");
                            Console.Beep(1000, SoundDuration);
                            Console.Beep(1000, SoundDuration);
                            KeyboardInteraction.PressButtonB();
                            Thread.Sleep(20);
                            Purchase.Abilities.PurchaseAbilities();
                            Thread.Sleep(20);
                            KeyboardInteraction.PressButtonB();
                            Globals.Config.CheckFirstRound = false;
                            break;
                        }


                        FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
                        (
                            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(
                                FirstRoundOperations.ImageVariables.ValorantImage),
                            FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.FirstRoundOfHalf9)
                        );


                        if (FirstRoundOperations.ImageVariables.maxVal > 0.85)
                        {
                            Console.WriteLine("First game started with FirstRoundOfHalf9");
                            Console.Beep(1000, SoundDuration);
                            Console.Beep(1000, SoundDuration);
                            KeyboardInteraction.PressButtonB();
                            Thread.Sleep(20);
                            Purchase.Abilities.PurchaseAbilities();
                            Thread.Sleep(20);
                            KeyboardInteraction.PressButtonB();
                            Globals.Config.CheckFirstRound = false;
                            break;
                        }

                        // Cv2.ImShow("Original Source", FirstRoundOperations.ImageVariables.ValorantImage);
                        Thread.Sleep(150);
                        Cv2.WaitKey(10);
                        GC.Collect();
        }

                }
                break;
            

            default:
                Globals.Config.CheckFirstRound = false;
                Console.Clear();
                break;
        }
        
        
        
        

        
        
        
    }
}