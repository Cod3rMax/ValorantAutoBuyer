using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantAutoBuyer.LockAgent
{
    public class LockInButton
    {

        public static void GetLockinButton()
        {
            int width = (Helper.ValorantWindow._rect.Right - Helper.ValorantWindow._rect.Left) / 2;
            int height = (Helper.ValorantWindow._rect.Buttom - Helper.ValorantWindow._rect.Top) / 2;
            Helper.CursorPosition.SetCursorPos(width, height + (height - (height / 2)));
        }


    }
}
