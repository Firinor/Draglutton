using System;
using System.Threading.Tasks;
using UnityEngine;

public class Intro_d : DialogNode
{
    [SerializeField]
    private string[] Header = new
        string[2] { "������", "Start" };

    [SerializeField]
    private CharacterInformator Speaker;
    [SerializeField]
    private CharacterInformator Artur;
    [SerializeField]
    private CharacterInformator Knight;
    [SerializeField]
    private CharacterInformator Olivia;
    [SerializeField]
    private CharacterInformator Orc;
    [SerializeField]
    private CharacterInformator Mark;
    [SerializeField]
    private CharacterInformator Uysyf;

    [SerializeField]
    private Sprite Lab;
    [SerializeField]
    private Sprite Island;
    [SerializeField]
    private Sprite Tavern;

    public override string GetHeader()
    {
        return Header[(int)PlayerManager.Language];
    }

    public override async void StartDialog()
    {
        base.StartDialog();

        await PrintText("");

        await PrintText("...");

        await PrintText("��� ������� ������ �����!");

        await Say(Speaker, "������!");

        await Say(Speaker, "��� ������� �������� ��� ����������� �� �����.");

        Show(Uysyf, PositionOnTheStage.Center);

        await Say(Uysyf, "��� ������� �������� ����������� �� �������� �����.");

        Show(Artur, PositionOnTheStage.Center);
        Show(Knight, PositionOnTheStage.Left);
        Show(Olivia, PositionOnTheStage.Left);
        Show(Orc, PositionOnTheStage.Right);
        Show(Mark, PositionOnTheStage.Right);

        await Say(Uysyf, "������������ �� ����� ����� ���� �� ����� 6 ����������. ��������� �� ����� �����������.");
        await Say(Olivia, "��������� �������� ���������� �� ���� ������.");

        Scene(Lab);
        await Say(Olivia, "��� ��� �������� ������.");

        SceneOff();
        await Say(Olivia, "������� � ���������� ����� ���������.");

        Scene(Island);

        Hide(Artur);
        Hide(Knight);
        Hide(Olivia);
        Hide(Orc);

        await Say(Uysyf, "������� ����� ��������");

        Scene(Tavern);

        await Say(Olivia, "��������� ����� �������� ��-�� �����.");

        Show(Mark, PositionOnTheStage.Left);

        await PrintText("��������� ����� ������������ �� �����. ���� ������������ � ������ ������� ������ �� �����.");

        await Say(Mark, "���� ��� �)");

        await Say(Mark, "���� ����������� ������� �� ���������� ��������� �������:");

        Fork();
    }
}
