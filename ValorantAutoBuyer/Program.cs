﻿using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ValorantAutoBuyer.Helper;
using WindowsInput;
using WindowsInput.Native;

namespace ValorantAutoBuyer
{
    internal class Program
    {
        


        public static void Main(string[] args)
        {
            Display.Header.ValorantAutoBuyerHeader();
            var hWind = Helper.ValorantWindow.FindWindow(IntPtr.Zero, "VALORANT  ");
            Helper.ValorantWindow.GetWindowRect(hWind, out Helper.ValorantWindow._rect);
            
            while (true)
            {
                
                // For the first round (I need abilities only)
                if (Helper.KeyboardState.GetAsyncKeyState(Keys.F1) < 0)
                {
                    Functions.KeyboardInteraction.PressButtonB();
                    Purchase.Abilities.PurchaseAbilities();
                    Functions.KeyboardInteraction.PressButtonB();
                    Thread.Sleep(20);
                }

                // Buy Spectre with LightShield
                else if (Helper.KeyboardState.GetAsyncKeyState(Keys.F2) < 0)
                {
                    Functions.KeyboardInteraction.PressButtonB();
                    Purchase.Spectre.PurchaseSpectre();
                    Purchase.Shields.PurchaseLightShields();
                    Purchase.Abilities.PurchaseAbilities();
                    Functions.KeyboardInteraction.PressButtonB();
                    Thread.Sleep(20);
                }
                
                
                // Buy bulldog with light shields
                else if (Helper.KeyboardState.GetAsyncKeyState(Keys.F3) < 0)
                {
                    Functions.KeyboardInteraction.PressButtonB();
                    Purchase.Bulldog.PurchaseBulldog();
                    Purchase.Shields.PurchaseLightShields();
                    Purchase.Abilities.PurchaseAbilities();
                    Functions.KeyboardInteraction.PressButtonB();
                    Thread.Sleep(20);
                }
                
                // Buy vandal with full
                else if (Helper.KeyboardState.GetAsyncKeyState(Keys.F5) < 0)
                {
                    Functions.KeyboardInteraction.PressButtonB();
                    Purchase.Vandal.PurchaseVandal();
                    Purchase.Shields.PurchaseHeavyShields();
                    Purchase.Abilities.PurchaseAbilities();
                    Functions.KeyboardInteraction.PressButtonB();
                    Thread.Sleep(20);
                }
                
                // Buy Phantom with full
                else if (Helper.KeyboardState.GetAsyncKeyState(Keys.F6) < 0)
                {
                    Functions.KeyboardInteraction.PressButtonB();
                    Purchase.Phantom.PurchasePhantom();
                    Purchase.Shields.PurchaseHeavyShields();
                    Purchase.Abilities.PurchaseAbilities();
                    Functions.KeyboardInteraction.PressButtonB();
                    Thread.Sleep(20);
                }
                
                
            }
        }
        
        
        

        
        
    }
}