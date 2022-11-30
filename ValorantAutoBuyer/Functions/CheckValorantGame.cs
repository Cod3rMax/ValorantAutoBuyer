using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using Console = Colorful.Console;
namespace ValorantAutoBuyer.Functions;



public class CheckValorantGame
{

    public static Thread CheckGameOpenedThread = new Thread(CheckGameOpened);

    public static void CheckGameOpened()
    {

        while (true)
        {
            Process[] proc = Process.GetProcessesByName("Valorant");
            if (proc.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("[** Error **] => Open Valorant Game!.", Color.Red);
            }
            else
            {
                Console.Clear();
                Display.Header.ValorantAutoBuyerHeader();
                Functions.CheckUserInput.StartAutoBuyer();
            }
            Thread.Sleep(1500);
        }
        
    }
}
