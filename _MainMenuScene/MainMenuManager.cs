using System;
using UnityEngine;

public enum MenuMarks { play, baner, credits, options, off };

public class MainMenuManager : SinglBehaviour<MainMenuManager>, IScenePanel
{
    private static GameObject baner;
    private static GameObject credits;

    private MainMenuInformator mainMenuInformator;

    public void SetAllInstance()
    {
        SingletoneCheck(this);
        SceneManager.ScenePanel = this;

        mainMenuInformator = GetComponent<MainMenuInformator>();
        mainMenuInformator.SingletoneCheck(mainMenuInformator);//Singltone

        baner = MainMenuInformator.GetBaner();
        credits = MainMenuInformator.GetCredits();
    }

    public static void SwitchPanels(MenuMarks mark)
    {
        instance.DiactiveAllPanels();
        switch (mark)
        {
            case MenuMarks.play:
                SceneManager.LoadScene("DragonRoom");
                break;
            case MenuMarks.baner:
                baner.SetActive(true);
                break;
            case MenuMarks.credits:
                credits.SetActive(true);
                break;
            case MenuMarks.options:
                SceneManager.SwitchPanels(SceneDirection.options);
                break;
            case MenuMarks.off:
                break;
            default:
                new Exception("Unrealized bookmark!");
                break;
        }
    }

    public void SwitchPanels(int mark)
    {
        SwitchPanels((MenuMarks)mark);
    }

    public void DiactiveAllPanels()
    {
        //baner.SetActive(false);
        credits.SetActive(false);
        SceneManager.DiactiveAllPanels();
    }
    public void BasicPanelSettings()
    {
        SwitchPanels(MenuMarks.baner);
    }
}
