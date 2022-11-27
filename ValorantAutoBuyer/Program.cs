using System;
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
            var hWind = Helper.ValorantWindow.FindWindow(IntPtr.Zero, "VALORANT  ");
            Helper.ValorantWindow.GetWindowRect(hWind, out Helper.ValorantWindow._rect);
            
            while (true)
            {
                if (Helper.KeyboardState.GetAsyncKeyState(Keys.NumPad1) < 0)
                {
                    new InputSimulator().Keyboard.KeyPress(VirtualKeyCode.VK_B);
                    Purchase.Ghost.PurchaseGhost();
                    Purchase.Shields.PurchaseHeavyShields();
                    Purchase.Abilities.PurchaseAbilities();
                    new InputSimulator().Keyboard.KeyPress(VirtualKeyCode.VK_B);
                    Thread.Sleep(20);
                }
            }


        }
        
        
        

        
        
    }
}