using System.Collections.Generic;

public static class PlayerManager
{
    public static int Account;

    private static Dictionary<int, bool> progress;
    public static Dictionary<int, bool> GetProgress()
    {
        if(progress == null)
        {
            progress = new Dictionary<int, bool>();
        }
        return progress;
    }

    public static void OnLoad()
    {
        //Account = SaveManager.PlayerAccount();
    }
}
