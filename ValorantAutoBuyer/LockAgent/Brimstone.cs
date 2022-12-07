using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ValorantAutoBuyer.LockAgent
{
    public class Brimstone
    {
        public static void LockBrimstone()
        {
            SpeechSynthesizer speaker = new SpeechSynthesizer();
            speaker.Volume = 100;
            speaker.Rate = -1;



            int width = (Helper.ValorantWindow._rect.Right - Helper.ValorantWindow._rect.Left) / 2;
            int height = (Helper.ValorantWindow._rect.Buttom - Helper.ValorantWindow._rect.Top) / 2;
            Helper.CursorPosition.SetCursorPos((width / 2) + (width / 4) + 40, height + height - (height / 4) - 30);
            Functions.CursorInteraction.CursorClick();
            Thread.Sleep(10);
            Functions.CursorInteraction.CursorClick();


            Thread.Sleep(10);
            LockAgent.LockInButton.GetLockinButton();
            Thread.Sleep(10);
            Functions.CursorInteraction.CursorClick();



            speaker.Speak("Brimstone has been locked");
        }
    }
}
