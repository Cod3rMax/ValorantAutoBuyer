﻿using System;
using System.Drawing;
using System.Speech.Synthesis;
using System.Threading;
using AutoItX3Lib;
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










    public static void StartLockAgentProcess()
    {
        var speech = new SpeechSynthesizer();
        speech.Volume = 100;
        AutoItX3 au3 = new AutoItX3();
        while(true)
        {

            var hWind = Helper.ValorantWindow.FindWindow(IntPtr.Zero, "VALORANT  ");
            Helper.ValorantWindow.GetWindowRect(hWind, out Helper.ValorantWindow._rect);
            
            object SearchPixel1 = au3.PixelSearch(Helper.ValorantWindow._rect.Left, Helper.ValorantWindow._rect.Top, Helper.ValorantWindow._rect.Right, Helper.ValorantWindow._rect.Buttom, 0x615552);
            object SearchPixel2 = au3.PixelSearch(Helper.ValorantWindow._rect.Left, Helper.ValorantWindow._rect.Top, Helper.ValorantWindow._rect.Right, Helper.ValorantWindow._rect.Buttom, 0x594C4C);
            object SearchPixel3 = au3.PixelSearch(Helper.ValorantWindow._rect.Left, Helper.ValorantWindow._rect.Top, Helper.ValorantWindow._rect.Right, Helper.ValorantWindow._rect.Buttom, 0x47474A);
            object SearchPixel4 = au3.PixelSearch(Helper.ValorantWindow._rect.Left, Helper.ValorantWindow._rect.Top, Helper.ValorantWindow._rect.Right, Helper.ValorantWindow._rect.Buttom, 0x6C5F57);
            object SearchPixel5 = au3.PixelSearch(Helper.ValorantWindow._rect.Left, Helper.ValorantWindow._rect.Top, Helper.ValorantWindow._rect.Right, Helper.ValorantWindow._rect.Buttom, 0xB08570);
            object SearchPixel6 = au3.PixelSearch(Helper.ValorantWindow._rect.Left, Helper.ValorantWindow._rect.Top, Helper.ValorantWindow._rect.Right, Helper.ValorantWindow._rect.Buttom, 0x2B374C);

            if (SearchPixel1.ToString() != "0" && SearchPixel2.ToString() != "0" && SearchPixel3.ToString() != "0" && SearchPixel4.ToString() != "0" && SearchPixel5.ToString() != "0" && SearchPixel6.ToString() != "0")
            {


                switch (Globals.Config.AgentToLock)
                {
                    case var _ when Globals.Config.AgentToLock == "astra":
                        LockAgent.Astra.LockAstra();
                        break;

                    default:
                        break;
                }


                Globals.Config.AutoLockAgent = false;
                break;
            }
            GC.Collect();
        }

    }
    
    
    
    
}