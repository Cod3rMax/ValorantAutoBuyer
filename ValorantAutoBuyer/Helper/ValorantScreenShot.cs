using System;
using System.Drawing;

namespace ValorantAutoBuyer.Helper;

public class ValorantScreenShot
{
    public static Bitmap TakeValorantScreenShot()
    {
        Bitmap bitmap = new Bitmap(Helper.ValorantWindow._rect.Right - Helper.ValorantWindow._rect.Left, Helper.ValorantWindow._rect.Buttom - Helper.ValorantWindow._rect.Top);
        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            graphics.CopyFromScreen(Helper.ValorantWindow._rect.Left, Helper.ValorantWindow._rect.Top, 0,0, new System.Drawing.Size(Helper.ValorantWindow._rect.Right - Helper.ValorantWindow._rect.Left, Helper.ValorantWindow._rect.Buttom - Helper.ValorantWindow._rect.Top));
        }
        GC.Collect();
        return bitmap;
    }
}