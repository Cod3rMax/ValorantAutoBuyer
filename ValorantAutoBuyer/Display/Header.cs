using System;
using System.Drawing;
using Console = Colorful.Console;

namespace ValorantAutoBuyer.Display
{
    public class Header
    {
        private static readonly string Line1 = " █████╗ ██╗   ██╗████████╗ ██████╗ ██████╗ ██╗   ██╗██╗   ██╗███████╗██████╗";
        private static readonly string Line2 = " ██╔══██╗██║   ██║╚══██╔══╝██╔═══██╗██╔══██╗██║   ██║╚██╗ ██╔╝██╔════╝██╔══██╗";
        private static readonly string Line3 = " ███████║██║   ██║   ██║   ██║   ██║██████╔╝██║   ██║ ╚████╔╝ █████╗  ██████╔╝";
        private static readonly string Line4 = " ██╔══██║██║   ██║   ██║   ██║   ██║██╔══██╗██║   ██║  ╚██╔╝  ██╔══╝  ██╔══██╗";
        private static readonly string Line5 = " ██║  ██║╚██████╔╝   ██║   ╚██████╔╝██████╔╝╚██████╔╝   ██║   ███████╗██║  ██║";
        private static readonly string Line6 = " ╚═╝  ╚═╝ ╚═════╝    ╚═╝    ╚═════╝ ╚═════╝  ╚═════╝    ╚═╝   ╚══════╝╚═╝  ╚═╝";
        private static readonly string Line7 = "~ Made by Cod3rMax ~";
        private static readonly string Line8 = @"{ Discord: https://discord.gg/Dxh3yY3TqA }";
        public static void ValorantAutoBuyerHeader()
        {
            Console.WindowWidth = 130;
            Console.WindowHeight = 35;

            Console.WriteLine();

            Console.SetCursorPosition((int)Math.Round((Console.WindowWidth - Line1.Length) / 2.0),
                Console.CursorTop);
            Console.WriteLine(Line1, Color.Red);

            Console.SetCursorPosition((int)Math.Round((Console.WindowWidth - Line2.Length) / 2.0),
                Console.CursorTop);
            Console.WriteLine(Line2, Color.Red);

            Console.SetCursorPosition((int)Math.Round((Console.WindowWidth - Line3.Length) / 2.0),
                Console.CursorTop);
            Console.WriteLine(Line3, Color.Red);

            Console.SetCursorPosition((int)Math.Round((Console.WindowWidth - Line4.Length) / 2.0),
                Console.CursorTop);
            Console.WriteLine(Line4, Color.Red);

            Console.SetCursorPosition((int)Math.Round((Console.WindowWidth - Line5.Length) / 2.0),
                Console.CursorTop);
            Console.WriteLine(Line5, Color.Red);

            Console.SetCursorPosition((int)Math.Round((Console.WindowWidth - Line6.Length) / 2.0),
                Console.CursorTop);
            Console.WriteLine(Line6, Color.Red);

            Console.WriteLine();

            Console.SetCursorPosition((int)Math.Round((Console.WindowWidth - Line7.Length) / 2.0),
                Console.CursorTop);
            Console.WriteLine(Line7, Color.GreenYellow);

            Console.SetCursorPosition((int)Math.Round((Console.WindowWidth - Line8.Length) / 2.0),
                Console.CursorTop);
            Console.WriteLine(Line8, Color.Aqua);

            Console.WriteLine();

            Console.Write("[F1] => ", Color.GreenYellow);
            Console.Write("Purchase All Abilities only.", Color.BurlyWood);
            Console.WriteLine();

            Console.Write("[F2] => ", Color.GreenYellow);
            Console.Write("Purchase Spectre, Light Shield and the rest of money get All Abilities.", Color.BurlyWood);
            Console.WriteLine();

            Console.Write("[F3] => ", Color.GreenYellow);
            Console.Write("Purchase Bulldog, Light Shield and the rest of money get All Abilities.", Color.BurlyWood); Console.WriteLine();

            Console.Write("[F5] => ", Color.GreenYellow);
            Console.Write("Purchase Vandal, Heavy Shield and All Abilities.", Color.BurlyWood);
            Console.WriteLine();

            Console.Write("[F6] => ", Color.GreenYellow);
            Console.Write("Purchase Phantom, Heavy Shield and All Abilities.", Color.BurlyWood);
            Console.WriteLine();
            
            Console.Write("[F9] => ", Color.GreenYellow);
            Console.Write("Toxic Brim, Purchase All Abilities, HeavyShield, Judge, Ghost.", Color.BurlyWood);
            Console.WriteLine();
            
            Console.WriteLine();
            Console.Write("[*] => Choose your purchase in game:", Color.BurlyWood);
        }
    }
}