using System.Collections.Generic;

public static class LanguageInformator
{
    private static Dictionary<string, Dictionary<Languages, string>> Texts
        = new Dictionary<string, Dictionary<Languages, string>>()
    {
            ["Play"] = { { Languages.RU, "�����" }, { Languages.EN, "Start" } },
            ["Options"] = { { Languages.RU, "���������" }, { Languages.EN, "Options" } },
            ["Credits"] = { { Languages.RU, "���������" }, { Languages.EN, "Credits" } },
            ["Exit"] = { { Languages.RU, "�����" }, { Languages.EN, "Exit" } },
            ["Return"] = { { Languages.RU, "����������" }, { Languages.EN, "Return" } },
            ["Creators"] = { { 
                    Languages.RU, "�����������: ��� ������� ��������" }, { 
                    Languages.EN, "Developer: sir Firinor Hisimeon" } },
            ["OptionsFullScreen"] = { { Languages.RU, "���������" }, { Languages.EN, "Options" } },
            ["OptionsScreenResolution"] = { { Languages.RU, "���������� ������" }, { Languages.EN, "Screen resolution" } },
            ["OptionsVolume"] = { { Languages.RU, "����" }, { Languages.EN, "Volume" } },
            ["OptionsMouseSensitivity"] = { { Languages.RU, "���������������� ����" }, { Languages.EN, "Mouse sensitivity" } },
            ["OptionsLanguage"] = { { Languages.RU, "����" }, { Languages.EN, "Language" } },
        };

    public static string GetText(string name, Languages language)
    {
        return Texts[name][language];
    }
}
