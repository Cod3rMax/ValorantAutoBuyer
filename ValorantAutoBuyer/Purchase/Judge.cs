using System.Threading;
using ValorantAutoBuyer.Helper;

namespace ValorantAutoBuyer.Purchase;

public class Judge
{
    public static void PurchaseJudge()
    {
        Thread.Sleep(30);
        var _width = (Helper.ValorantWindow._rect.Right + Helper.ValorantWindow._rect.Left) / 2;
        var _height = (Helper.ValorantWindow._rect.Buttom + Helper.ValorantWindow._rect.Top) / 2;
        CursorPosition.SetCursorPos(_width - (_width) / 3, _height + (_height) / 2 - (_height) / 4);
        Functions.CursorInteraction.CursorClick();
    }
}