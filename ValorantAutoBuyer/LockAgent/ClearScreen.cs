using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantAutoBuyer.LockAgent
{
    public class ClearScreen
    {

        // Clean the screen and show the auto agent lock OFF when the agent is locked.

        public static void AgentLockedClear()
        {
            Globals.Config.AutoLockAgent = false;
            Console.Clear();
            Display.Header.ValorantAutoBuyerHeader();
            Display.Header.ValorantAutoBuyerOptions();
        }





    }
}
