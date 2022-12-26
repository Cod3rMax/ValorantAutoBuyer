using System;
using System.Drawing;

namespace ValorantAutoBuyer.Helper;

public class ValorantScreenShot
{
    public static Bitmap bitmap;
    public static Bitmap TakeValorantScreenShot()
    { 
        bitmap = new Bitmap(ValorantWindow._rect.Right - ValorantWindow._rect.Left, ValorantWindow._rect.Buttom - ValorantWindow._rect.Top);
        
        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            graphics.CopyFromScreen(Helper.ValorantWindow._rect.Left, Helper.ValorantWindow._rect.Top, 0,0, new System.Drawing.Size(Helper.ValorantWindow._rect.Right - Helper.ValorantWindow._rect.Left, Helper.ValorantWindow._rect.Buttom - Helper.ValorantWindow._rect.Top));
        }
        return bitmap;
    }
}