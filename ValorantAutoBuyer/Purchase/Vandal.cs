using System.Threading;
using ValorantAutoBuyer.Helper;

namespace ValorantAutoBuyer.Purchase
{
    public class Vandal
    {
        public static void PurchaseVandal()
        {
            Thread.Sleep(40);
            var _width = (Helper.ValorantWindow._rect.Right + Helper.ValorantWindow._rect.Left) / 2;
            var _height = (Helper.ValorantWindow._rect.Buttom + Helper.ValorantWindow._rect.Top) / 2;
            CursorPosition.SetCursorPos(_width, _height + 80);
            Functions.CursorInteraction.CursorClick();
        }

    }
}