using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsOperator : SinglBehaviour<OptionsOperator>
{
    [SerializeField]
    private AudioMixerGroup mixerMasterGroup;
    [SerializeField]
    public Slider volumeSlider;
    [SerializeField]
    private AnimationCurve curve;

    private static bool OnLoad;

    public void Return()
    {
        gameObject.SetActive(false);
    }
    public void Exit()
    {
        SceneManager.SwitchPanels(SceneDirection.exit);
    }
    public void RestoreDefault()
    {

    }
    public void FullScreen(Toggle toggle)
    {
        bool v = toggle.isOn;
        OptionsManager.FullScreen = v;

        if (!OnLoad) { }
            //SaveManager.SaveOptions();
    }
    public void ScreenResolution(Dropdown dropdown)
    {
        int i = dropdown.value;
        OptionsManager.CurrentScreenResolution = OptionsManager.GetResolution(i);

        if (!OnLoad) { }
            //SaveManager.SaveOptions(ScreenResolution: i);
    }
    public void MasterVolume()
    {
        if (instance == null)
            return;

        float volume = Mathf.Lerp(-80f, 0, curve.Evaluate(GetVolume()));

        mixerMasterGroup.audioMixer.SetFloat("MasterVolume", volume);
        if (!OnLoad) { }
            //SaveManager.SaveOptions();
    }
    public static float GetVolume()
    {
        if (instance == null)
            return default;

        //volumeSlider minValue = -1, minValue = 1
        return instance.volumeSlider.value / 2 + .5f;
    }

    public static OptionsParameters GetParameters(int ScreenResolutoin = -1)
    {
        return new OptionsParameters(OptionsManager.FullScreen, ScreenResolutoin, instance.volumeSlider.value, 0);
    }

    public static void LoadOptions()
    {
        if (instance == null)
            return;

        OnLoad = true;
        //var parametrs = SaveManager.LoadOptions();
        //instance.fullScreen = parametrs.fullScreen;
        //instance.screenResolution = parametrs.screenResolution;
        //instance.volumeSlider.value = parametrs.volume;
        //instance.language = parametrs.language;
        OnLoad = false;
    }
}

[Serializable]
public struct OptionsParameters
{
    public bool fullScreen;
    public int screenResolution;
    public float volume;
    public int language;

    public OptionsParameters(bool fullScreen, int screenResolution, float volume, int language)
    {
        this.fullScreen = fullScreen;
        this.screenResolution = screenResolution;
        this.volume = volume;
        this.language = language;
    }
}