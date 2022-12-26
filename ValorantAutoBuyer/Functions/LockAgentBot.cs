using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Threading;
using AutoItX3Lib;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using ValorantAutoBuyer.FirstRoundOperations;
using ValorantAutoBuyer.Globals;
using ValorantAutoBuyer.Helper;
using Console = Colorful.Console;

namespace ValorantAutoBuyer.Functions;

public class LockAgentBot
{
    public static void LockAgentSniper()
    {
        
        while (Globals.Config.AgentLockingProcessON)
        {
            Display.Header.ValorantAutoBuyerHeader();
            Console.Write("[*] => Would you like to lock an agent? (Y/N): ", Color.Orange);
            var AutoLockAgentUserAnswer = Console.ReadLine();
            
            switch (AutoLockAgentUserAnswer)
            {
                case var _ when AutoLockAgentUserAnswer.ToString().ToLower() == "y" || AutoLockAgentUserAnswer.ToString().ToLower() == "yes":
                    
                    while (Globals.Config.CorrectUserAgentEntered == false)
                    {
                        Console.Write("[*] => Choose an agent? (Astra, Breach, Brimstone...): ", Color.Orange);
                        var UserAgentToLock = Console.ReadLine();

                        if (UserAgentToLock.ToString().ToLower() == "astra")
                        {
                            Globals.Config.AgentToLock = "astra";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        else if (UserAgentToLock.ToString().ToLower() == "breach")
                        {
                            Globals.Config.AgentToLock = "breach";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "brimstone")
                        {
                            Globals.Config.AgentToLock = "brimstone";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "chamber")
                        {
                            Globals.Config.AgentToLock = "chamber";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                    
                        else if (UserAgentToLock.ToString().ToLower() == "cypher")
                        {
                            Globals.Config.AgentToLock = "cypher";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "fade")
                        {
                            Globals.Config.AgentToLock = "fade";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "harbor")
                        {
                            Globals.Config.AgentToLock = "harbor";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "jett")
                        {
                            Globals.Config.AgentToLock = "jett";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }

                        else if (UserAgentToLock.ToString().ToLower() == "kayo")
                        {
                            Globals.Config.AgentToLock = "kayo";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "killjoy")
                        {
                            Globals.Config.AgentToLock = "killjoy";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "neon")
                        {
                            Globals.Config.AgentToLock = "neon";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "omen")
                        {
                            Globals.Config.AgentToLock = "omen";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "phoenix")
                        {
                            Globals.Config.AgentToLock = "phoenix";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "raze")
                        {
                            Globals.Config.AgentToLock = "raze";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "reyna")
                        {
                            Globals.Config.AgentToLock = "reyna";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "sage")
                        {
                            Globals.Config.AgentToLock = "sage";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "skye")
                        {
                            Globals.Config.AgentToLock = "skye";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "sova")
                        {
                            Globals.Config.AgentToLock = "sova";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "viper")
                        {
                            Globals.Config.AgentToLock = "viper";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else if (UserAgentToLock.ToString().ToLower() == "yoru")
                        {
                            Globals.Config.AgentToLock = "yoru";
                            Globals.Config.CorrectUserAgentEntered = true;
                            Config.AutoLockAgent = true;
                            Globals.Config.AgentLockingProcessON = false;
                            Console.Clear();
                        }
                        
                        else
                        {
                            Console.WriteLine("[x] => Agent doesn't exists! ", Color.Red);
                        }
                        
                    }
                    
                    break;



                default:
                    Config.AutoLockAgent = false;
                    Globals.Config.AgentLockingProcessON = false;
                    Console.Clear();
                    break;
            }

        }
        
    }






    [DllImport("user32.dll")]
    static extern IntPtr GetForegroundWindow();



    public static void StartLockAgentProcess()
    {
        var speech = new SpeechSynthesizer();
        speech.Volume = 100;
        while(true)
        {
            var hWind = Helper.ValorantWindow.FindWindow(IntPtr.Zero, "VALORANT  ");
            Helper.ValorantWindow.GetWindowRect(hWind, out Helper.ValorantWindow._rect);
            
                // Keep taking screenshots of the game if the game is not minimized

                if(ValorantWindow._rect.Right - ValorantWindow._rect.Left != 0 && ValorantWindow._rect.Buttom - ValorantWindow._rect.Top != 0){

                    try 
                    {
                        
                        FirstRoundOperations.ImageVariables.ValorantImage = new Mat
                        (
                            new OpenCvSharp.Size(Helper.ValorantWindow._rect.Right - Helper.ValorantWindow._rect.Left, 
                                Helper.ValorantWindow._rect.Buttom - Helper.ValorantWindow._rect.Top), MatType.CV_8UC3
                        );
                        BitmapConverter.ToMat(ValorantScreenShot.TakeValorantScreenShot(), FirstRoundOperations.ImageVariables.ValorantImage);
                    }
                    catch (Exception e) 
                    { 
                        Console.WriteLine("[** Error **] => You need to restart ValorantAutoBuyer!.", Color.Red);
                    }
               
                
                // Convert the image to gray
                Cv2.CvtColor
                (
                    FirstRoundOperations.ImageVariables.ValorantImage,
                    FirstRoundOperations.ImageVariables.ValorantImageToGray,
                    ColorConversionCodes.BGR2GRAY
                );
                
                

                
            FirstRoundOperations.MatchTemplateToGetFirstRound.GetPredictionMatchForFirstRound
            (
                FirstRoundOperations.ImageVariables.ValorantImage, FirstRoundOperations.ImageVariables.AutoLockAgentNeedle3
            );

            
            if (FirstRoundOperations.ImageVariables.maxVal > 0.70)
            {


                switch (Globals.Config.AgentToLock)
                {
                    case var _ when Globals.Config.AgentToLock == "astra":
                        LockAgent.Astra.LockAstra();
                        break;

                    case var _ when Globals.Config.AgentToLock == "breach":
                        LockAgent.Breach.LockBreach();
                        break;

                    case var _ when Globals.Config.AgentToLock == "brimstone":
                        LockAgent.Brimstone.LockBrimstone();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "chamber":
                        LockAgent.Chamber.LockChamber();
                        break;
                        
                    case var _ when Globals.Config.AgentToLock == "cypher":
                        LockAgent.Cypher.LockCypher();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "fade":
                        LockAgent.Fade.LockFade();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "harbor":
                        LockAgent.Harbor.LockHarbor();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "jett":
                        LockAgent.Jett.LockJett();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "kayo":
                        LockAgent.Kayo.LockKayo();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "killjoy":
                        LockAgent.Killjoy.LockKilljoy();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "neon":
                        LockAgent.Neon.LockNeon();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "omen":
                        LockAgent.Omen.LockOmen();
                        break;
                        
                    case var _ when Globals.Config.AgentToLock == "phoenix":
                        LockAgent.Phoenix.LockPhoenix();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "raze":
                        LockAgent.Raze.LockRaze();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "reyna":
                        LockAgent.Reyna.LockReyna();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "sage":
                        LockAgent.Sage.LockSage();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "skye":
                        LockAgent.Skye.LockSkye();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "sova":
                        LockAgent.Sova.LockSova();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "viper":
                        LockAgent.Viper.LockViper();
                        break;
                    
                    case var _ when Globals.Config.AgentToLock == "yoru":
                        LockAgent.Yoru.LockYoru();
                        break;
                    
                    
                    default:
                        break;
                }


                Globals.Config.AutoLockAgent = false;
                break;
            }
            
            
                }
                
                
            GC.Collect();
        }

    }
    
    
    
    
}