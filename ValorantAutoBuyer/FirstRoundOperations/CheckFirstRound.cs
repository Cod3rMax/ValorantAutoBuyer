using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using ValorantAutoBuyer.Functions;
using ValorantAutoBuyer.Helper;

namespace ValorantAutoBuyer.FirstRoundOperations;

public class CheckFirstRound
{

    public static int SoundDuration = 200;
    
    public static void CheckIfFirstRound()
    {

        // Ask the user here if he wants to purchase all abilities on the first round.
        Colorful.Console.Write("[*] => Would you like to purchase all abilities on first round? (Y/N): ", Color.Orange);
        var FirstRoundUserAnswer = Colorful.Console.ReadLine();
        
        switch (FirstRoundUserAnswer)
        {
            case var _ when FirstRoundUserAnswer.ToString().ToLower() == "y" || FirstRoundUserAnswer.ToString().ToLower() == "yes":
                Globals.Config.CheckFirstRound = true;
                Console.Clear();
                break;
            

            default:
                Globals.Config.CheckFirstRound = false;
                Console.Clear();
                break;
        }

    }



    public static void startProcessFirstRound()
    {
        while (Globals.Config.CheckFirstRound)
                {
                    
                    var hWind = Helper.ValorantWindow.FindWindow(IntPtr.Zero, "VALORANT  ");
                    Helper.ValorantWindow.GetWindowRect(hWind, out Helper.ValorantWindow._rect);
                    
                    
                    
                    
                    

                    while (true)
                    {
                        // Keep taking screenshots of the game
                        try
                        {
                            
                            FirstRoundOperations.ImageVariables.ValorantImage = new Mat
                            (
                                new OpenCvSharp.Size(Helper.ValorantWindow._rect.Right - Helper.ValorantWindow._rect.Left, 
                                    Helper.ValorantWindow._rect.Buttom - Helper.ValorantWindow._rect.Top), MatType.CV_8UC3
                            );
                            
                            BitmapConverter.ToMat(ValorantScreenShot.TakeValorantScreenShot(), ImageVariables.ValorantImage);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("[** Error **] => First Round cannot be detected, Restart the program!.", Color.Red);
                        }

                        // Get the match test
                        FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
                        (
                            FirstRoundOperations.OriginalValorantSource.ImageOperationsOnOriginalImageSource(
                                FirstRoundOperations.ImageVariables.ValorantImage),
                            FirstRoundOperations.NeedleOperations.NeedleProcessor(FirstRoundOperations.ImageVariables.NeedleImage1)
                        );


                        
                        
                        
                        if (FirstRoundOperations.ImageVariables.maxVal > 0.82)
                        {
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
    }
    
    
    
    
    
}