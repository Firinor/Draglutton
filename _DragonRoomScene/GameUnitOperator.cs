using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameUnitOperator : MonoBehaviour,
    IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField]
    private Image mainImage;
    [SerializeField]
    private UpgradeCostOperator upgradeCostOperator;
    void Awake()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Upgrade");
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnPointerEnter " + gameObject.name);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("OnPointerExit " + gameObject.name);
    }
}
