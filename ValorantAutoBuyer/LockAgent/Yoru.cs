﻿using System.Speech.Synthesis;
using System.Threading;

namespace ValorantAutoBuyer.LockAgent;

public class Yoru
{
    public static void LockYoru()
    {
        SpeechSynthesizer speaker = new SpeechSynthesizer();
        speaker.Volume = 100;
        speaker.Rate = -1;



        int width = (Helper.ValorantWindow._rect.Right - Helper.ValorantWindow._rect.Left) / 2;
        int height = (Helper.ValorantWindow._rect.Buttom - Helper.ValorantWindow._rect.Top) / 2;
        Helper.CursorPosition.SetCursorPos((width / 2) + (width / 3) + (width / 2) + (width / 18), height + height - (height / 8));
        Functions.CursorInteraction.CursorClick();
        Thread.Sleep(10);
        Functions.CursorInteraction.CursorClick();


        Thread.Sleep(10);
        LockAgent.LockInButton.GetLockinButton();
        Thread.Sleep(10);
        Functions.CursorInteraction.CursorClick();

        speaker.Speak("Yoru has been locked");

        LockAgent.ClearScreen.AgentLockedClear();


    }

}