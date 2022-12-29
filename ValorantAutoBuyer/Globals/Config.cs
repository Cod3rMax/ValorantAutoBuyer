namespace ValorantAutoBuyer.Globals;

public class Config
{
    // Data to lock an agent, will be set according to user inputs
    public static bool AutoLockAgent = false;
    public static string AgentToLock;
    public static bool AgentLockingProcessON = true;  // This option true mean the program will ask the user if he wants to lock an agent, false it won't ask the user and start program directly
    public static bool CorrectUserAgentEntered = false; // Here to check weather the user choose the correct name of the agent or not
    
    
    
    // Here will be the config of detecting first round.
    public static bool CheckFirstRound = false;







}