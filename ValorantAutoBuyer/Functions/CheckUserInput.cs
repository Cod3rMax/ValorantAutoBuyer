using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Console = Colorful.Console;

namespace ValorantAutoBuyer.Functions;

public class CheckUserInput
{
    
    
    public static void StartAutoBuyer()
    {
        Helper.ShowDiscordToUser.DisplayDiscordServer();

        var threadCounter = 0;
        var detectFirstRound = 0;
        while (true)
        {
            
            // If valorant is closed this program also close
            Process[] proc = Process.GetProcessesByName("Valorant");
            if (proc.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("[** Error **] => Valorant Closed, Good Bye!.", Color.Red);
                Thread.Sleep(3000);
                Environment.Exit(1);
            }
            
            
            // Keep getting valorant window sizes everytime.
            var hWind = Helper.ValorantWindow.FindWindow(IntPtr.Zero, "VALORANT  ");
            Helper.ValorantWindow.GetWindowRect(hWind, out Helper.ValorantWindow._rect);

            
            // Send thread to auto lock agent
            if (Globals.Config.AutoLockAgent && threadCounter == 0)
            {
                new Thread(() => Functions.LockAgentBot.StartLockAgentProcess()) { IsBackground = true }.Start();
                threadCounter += 1;
            }
            
            
            // Send thread to detect first round only if auto lock agent is false
            if (Globals.Config.CheckFirstRound && detectFirstRound == 0 && !Globals.Config.AutoLockAgent)
            {
                new Thread(() => FirstRoundOperations.CheckFirstRound.startProcessFirstRound()) { IsBackground = true }.Start();
                detectFirstRound += 1;
            }
            
            
            // For the first round (I need abilities only)
            if (Helper.KeyboardState.GetAsyncKeyState(Keys.F1) < 0)
            {
                KeyboardInteraction.PressButtonB();
                Purchase.Abilities.PurchaseAbilities();
                KeyboardInteraction.PressButtonB();
                Thread.Sleep(20);
            }

            // Buy Spectre with LightShield
            else if (Helper.KeyboardState.GetAsyncKeyState(Keys.F2) < 0)
            {
                KeyboardInteraction.PressButtonB();
                Purchase.Spectre.PurchaseSpectre();
                Purchase.Shields.PurchaseLightShields();
                Purchase.Abilities.PurchaseAbilities();
                KeyboardInteraction.PressButtonB();
                Thread.Sleep(20);
            }

            // Buy bulldog with light shields
            else if (Helper.KeyboardState.GetAsyncKeyState(Keys.F3) < 0)
            {
                KeyboardInteraction.PressButtonB();
                Purchase.Bulldog.PurchaseBulldog();
                Purchase.Shields.PurchaseLightShields();
                Purchase.Abilities.PurchaseAbilities();
                KeyboardInteraction.PressButtonB();
                Thread.Sleep(20);
            }

            // Buy vandal with full
            else if (Helper.KeyboardState.GetAsyncKeyState(Keys.F5) < 0)
            {
                KeyboardInteraction.PressButtonB();
                Purchase.Vandal.PurchaseVandal();
                Purchase.Shields.PurchaseHeavyShields();
                Purchase.Abilities.PurchaseAbilities();
                KeyboardInteraction.PressButtonB();
                Thread.Sleep(20);
            }

            // Buy Phantom with full
            else if (Helper.KeyboardState.GetAsyncKeyState(Keys.F6) < 0)
            {
                KeyboardInteraction.PressButtonB();
                Purchase.Phantom.PurchasePhantom();
                Purchase.Shields.PurchaseHeavyShields();
                Purchase.Abilities.PurchaseAbilities();
                KeyboardInteraction.PressButtonB();
                Thread.Sleep(20);
            }
            
            
            // Buy Phantom with full
            else if (Helper.KeyboardState.GetAsyncKeyState(Keys.F9) < 0)
            {
                KeyboardInteraction.PressButtonB();
                Purchase.Judge.PurchaseJudge();
                Purchase.Ghost.PurchaseGhost();
                Purchase.Shields.PurchaseHeavyShields();
                Purchase.Abilities.PurchaseAbilities();
                KeyboardInteraction.PressButtonB();
                Thread.Sleep(20);
            }
            
            GC.Collect();
        }
    }
}