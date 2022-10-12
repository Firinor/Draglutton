using UnityEditor;
using UnityEngine;

public class MainMenuOperator : MonoBehaviour
{
    public void Play() => MainMenuManager.SwitchPanels(MenuMarks.play);
    public void Options() => MainMenuManager.SwitchPanels(MenuMarks.options);
    public void Credits() => MainMenuManager.SwitchPanels(MenuMarks.credits);
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
