using System.Threading;
using ValorantAutoBuyer.Helper;

namespace ValorantAutoBuyer.Purchase
{
    public class Abilities
    {
        public static void PurchaseAbilities()
        {
            Thread.Sleep(30);
            var _width = (Helper.ValorantWindow._rect.Right + Helper.ValorantWindow._rect.Left) / 2;
            var _height = (Helper.ValorantWindow._rect.Buttom + Helper.ValorantWindow._rect.Top) / 2;
            for (int i = 0; i < 4; i++)
            {
                CursorPosition.SetCursorPos(_width - (_width) / 2 - 200 + 277 * i + 277 , _height + (_height)/2 + 50);
                Functions.CursorInteraction.CursorClick();
                for (int j = 0; j < 4; j++)
                {
                    Thread.Sleep(30);
                    Functions.CursorInteraction.CursorClick();
                }
                
            }
        }
    }
}