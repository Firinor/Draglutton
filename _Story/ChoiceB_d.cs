using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ChoiceB_d : DialogNode
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

        await Say(Artur, "��� ������ ������� \"�\"", "Option \"B\" was selected");

        await Say(Artur, "�� ����� �������� �����, ��� �� ���������� ����� �������, ����� ������� \"��������� ������\"",
            "The dialog map shows that after the end of this dialog, it will start again \"Initial dialog\"");

        Fork();
    }

}
