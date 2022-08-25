using System;
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

    public override void StartDialog()
    {
        NoName("");

        NoName("...");

        NoName("��� ������� ������ �����!");

        Say(Speaker, "������!");

        Say(Speaker, "��� ������� �������� ��� ����������� �� �����.");

        Show(Uysyf, PositionOnTheStage.Center);

        Say(Uysyf, "��� ������� �������� ����������� �� �������� �����.");

        Show(Artur, PositionOnTheStage.Center);
        Show(Knight, PositionOnTheStage.Left);
        Show(Olivia, PositionOnTheStage.Left);
        Show(Orc, PositionOnTheStage.Right);
        Show(Mark, PositionOnTheStage.Right);

        Say(Uysyf, "������������ �� ����� ����� ���� �� ����� 6 ����������. ��������� �� ����� �����������.");
        Say(Olivia, "��������� �������� ���������� �� ���� ������.");

        Scene(Lab);
        Say(Olivia, "��� ��� �������� ������.");

        SceneOff();
        Say(Olivia, "������� � ���������� ����� ���������.");

        Scene(Island);

        Hide(Artur);
        Hide(Knight);
        Hide(Olivia);
        Hide(Orc);

        Say(Uysyf, "������� ����� ��������");

        Scene(Tavern);

        Say(Olivia, "��������� ����� �������� ��-�� �����.");

        Show(Mark, PositionOnTheStage.Left);

        NoName("��������� ����� ������������ �� �����. ���� ������������ � ������ ������� ������ �� �����.");

        Say(Mark, "���� ��� �)");

        Say(Mark, "���� ����������� ������� �� ���������� ��������� �������:");

        Fork();
    }
}
