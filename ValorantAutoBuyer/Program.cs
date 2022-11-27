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

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(IntPtr lpClassName, string lpWindowName);
        
        [DllImport("user32.dll", SetLastError=true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
        
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left, Top, Right, Buttom;
        }
        public static RECT _rect;


        public static void Main(string[] args)
        {
            var hWind = FindWindow(IntPtr.Zero, "VALORANT  ");
            GetWindowRect(hWind, out _rect);
            
            

            while (true)
            {
                if (Helper.KeyboardState.GetAsyncKeyState(Keys.NumPad1) < 0)
                {
                    new InputSimulator().Keyboard.KeyPress(VirtualKeyCode.VK_B);
                    PurchaseVandal();
                    PurchaseShields();
                    PurchaseAbilities();
                    new InputSimulator().Keyboard.KeyPress(VirtualKeyCode.VK_B);
                    Thread.Sleep(20);
                }
            }


        }

        
        
        public static void PurchaseAbilities()
        {
            Thread.Sleep(30);
            var _width = (_rect.Right + _rect.Left) / 2;
            var _height = (_rect.Buttom + _rect.Top) / 2;
            for (int i = 0; i < 4; i++)
            {
                CursorPosition.SetCursorPos(_width - (_width) / 2 - 200 + 277 * i + 277 , _height + (_height)/2 + 50);
                Helper.MouseMovment.mouse_event(Globals.Const.MOUSEEVENTF_LEFTDOWN,0,0,0,IntPtr.Zero);
                Helper.MouseMovment.mouse_event(Globals.Const.MOUSEEVENTF_LEFTUP,0,0,0,IntPtr.Zero);

                for (int j = 0; j < 4; j++)
                {
                    Thread.Sleep(30);
                    Helper.MouseMovment.mouse_event(Globals.Const.MOUSEEVENTF_LEFTDOWN,0,0,0,IntPtr.Zero);
                    Helper.MouseMovment.mouse_event(Globals.Const.MOUSEEVENTF_LEFTUP,0,0,0,IntPtr.Zero);
                }
                
            }
        }
        
        

        public static void PurchaseShields()
        {
            Thread.Sleep(30);
            var _width = (_rect.Right + _rect.Left) / 2;
            var _height = (_rect.Buttom + _rect.Top) / 2;
            CursorPosition.SetCursorPos(_width + (_width)/2, _height);
            Helper.MouseMovment.mouse_event(Globals.Const.MOUSEEVENTF_LEFTDOWN,0,0,0,IntPtr.Zero);
            Helper.MouseMovment.mouse_event(Globals.Const.MOUSEEVENTF_LEFTUP,0,0,0,IntPtr.Zero);
        }
        
        
        public static void PurchaseVandal()
        {
            Thread.Sleep(30);
            var _width = (_rect.Right + _rect.Left) / 2;
            var _height = (_rect.Buttom + _rect.Top) / 2;
            CursorPosition.SetCursorPos(_width, _height + 80);
            Helper.MouseMovment.mouse_event(Globals.Const.MOUSEEVENTF_LEFTDOWN,0,0,0,IntPtr.Zero);
            Helper.MouseMovment.mouse_event(Globals.Const.MOUSEEVENTF_LEFTUP,0,0,0,IntPtr.Zero);
        }
        
        
        
    }
}