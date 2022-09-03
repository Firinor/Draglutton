using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceA_d : DialogNode
{
    [SerializeField]
    private CharacterInformator Artur;

    [SerializeField]
    private Sprite scene;


    public override async void StartDialog()
    {
        base.StartDialog();

        Scene(scene);
        Show(Artur, PositionOnTheStage.Center);

        await Say(Artur, "��� ������ ������� \"�\"");

        await Say(Artur, "����� ��� �������, ������� �� ������������ �� ����� ���� ��������");

        Fork();
    }

}
