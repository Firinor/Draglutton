using System;
using System.Threading.Tasks;
using UnityEngine;

public class Intro_d : DialogNode
{
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

    public override async void StartDialog()
    {
        base.StartDialog();

        await Say("", "");

        await Say("...", "...");

        await Say("��� ������� ������ �����!", "This is a basic empty scene!");

        await Say(Speaker, "������!", "Hi!");

        await Say(Speaker, "��� ������� �������� ��� ����������� �� �����.", 
            "That's what a character says without being on stage.");

        Show(Uysyf, PositionOnTheStage.Center);

        await Say(Uysyf, "��� ������� �������� ����������� �� �������� �����.",
            "So says the character who appeared in the middle of the scene.");

        Show(Artur, PositionOnTheStage.Center);
        Show(Knight, PositionOnTheStage.Left);
        Show(Olivia, PositionOnTheStage.Left);
        Show(Orc, PositionOnTheStage.Right);
        Show(Mark, PositionOnTheStage.Right);

        await Say(Uysyf, "������������ �� ����� ����� ���� �� ����� 6 ����������. ��������� �� ����� �����������.",
            "There can be no more than 6 characters on the stage at the same time. Characters cannot be repeated.");
        await Say(Olivia, "��������� �������� ���������� �� ���� ������.",
            "The talking character highlights from the others.");

        Hide(Artur);
        Hide(Knight);
        Hide(Orc);

        Scene(Lab);

        await Say(Olivia, "��� ��� �������� ������.",
            "This is what the background looks like.");

        SceneOff();
        await Say(Olivia, "������� � ���������� ����� ���������.",
            "Background and characters can be disabled.");

        Scene(Island);
        Hide(Olivia);

        await Say(Uysyf, "������� ����� ��������",
            "Background may change");

        Scene(Tavern);

        await Say(Olivia, "��������� ����� �������� ��-�� �����.",
            "The characters are able to speak from behind the stage.");

        Show(Mark, PositionOnTheStage.Left);

        await Say("��������� ����� ������������ �� �����. ���� ������������ � ������ ������� ������ �� �����.",
            "The characters are able to move around the stage. Mark moved from the right side of the screen to the left.");

        await Say(Mark, "���� ��� �)",
            "Mark it's me)");

        await Say(Mark, "���� ����������� ������� �� ���������� ��������� �������:",
            "It is possible to choose from several answers:");

        Fork();
    }
}
