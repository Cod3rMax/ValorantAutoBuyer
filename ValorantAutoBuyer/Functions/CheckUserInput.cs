﻿using System.Threading;
using System.Windows.Forms;

namespace ValorantAutoBuyer.Functions;

public class CheckUserInput
{
    public static void StartAutoBuyer()
    {
        while (true)
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
    }
}