using System.Threading;
using ValorantAutoBuyer.Helper;

namespace ValorantAutoBuyer.Purchase
{
    public class Spectre
    {
        public static void PurchaseSpectre()
        {
            Thread.Sleep(40);
            var _width = (Helper.ValorantWindow._rect.Right + Helper.ValorantWindow._rect.Left) / 2;
            var _height = (Helper.ValorantWindow._rect.Buttom + Helper.ValorantWindow._rect.Top) / 2;
            CursorPosition.SetCursorPos(_width - (_width) / 3, _height - (_height) / 3);
            Functions.CursorInteraction.CursorClick();
        }
    }
}