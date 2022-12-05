using System;
using System.Diagnostics;
using Microsoft.Win32;

namespace ValorantAutoBuyer.Helper;

public class ShowDiscordToUser
{
    public static void DisplayDiscordServer()
    {
        try
        {
            RegistryKey discordRegistery = Registry.CurrentUser.OpenSubKey("ValorantBuyerDiscord");
            if (discordRegistery.GetValue("ShowDiscord").ToString() == "True")
            {
                Process.Start("https://discord.gg/Dxh3yY3TqA");
                discordRegistery.SetValue("ShowDiscord", false);
            }
            discordRegistery.Dispose();
            discordRegistery.Close();
        }
        catch (Exception e)
        {
            RegistryKey discordRegistery = Registry.CurrentUser.CreateSubKey("ValorantBuyerDiscord");
            discordRegistery.SetValue("ShowDiscord", false);
            Process.Start("https://discord.gg/Dxh3yY3TqA");
            discordRegistery.Close();
                
        }
    }
}