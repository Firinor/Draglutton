using UnityEngine;
using UnityEngine.UI;

public class SpeakerOperator : MonoBehaviour
{
    [SerializeField]
    private RectTransform rectTransform;
    [SerializeField]
    private Image image;
    [SerializeField]
    private Transform imageTransform;
    [SerializeField]
    private Canvas imageCanvas;
    [SerializeField]
    private Color speakerOnBackgroundColor;
    [SerializeField]
    private Vector3 scaleOnBackground;
    [SerializeField]
    [Range(0f, 1f)]
    private float unitScale;

    private static int backgroundSortingOrder = 2;
    private static int foregroundSortingOrder = 3;
    [SerializeField]
    private bool onBackground;

    internal void SetCharacter(CharacterInformator speaker)
    {
        image.sprite = speaker.unitSprite;
        image.SetNativeSize();
        unitScale = speaker.UnitScale;
        ToTheBackground();
    }

    public void ToTheBackground()
    {
        onBackground = true;
        image.color = speakerOnBackgroundColor;
        imageCanvas.sortingOrder = DialogOperator.OrderLayer + backgroundSortingOrder;
        ScaleUnit();
    }

    public void ToTheForeground()
    {
        onBackground = false;
        image.color = Color.white;
        imageCanvas.sortingOrder = DialogOperator.OrderLayer + foregroundSortingOrder;
        ScaleUnit();
    }

    [ContextMenu("ScaleUnit")]
    private void ScaleUnit()
    {
        float coefficient = DialogOperator.RectTransformHeight / image.preferredHeight;
        switch (onBackground)
        {
            case true:
                imageTransform.localScale = scaleOnBackground * coefficient * unitScale;
                break;
            case false:
                imageTransform.localScale = Vector3.one * coefficient * unitScale;
                break;
        }
    }
}
