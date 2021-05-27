using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class hoverToolTip : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public GameObject ToolTip1,tooltip2;
    public bool upgradeGotten;

    public void Update()
    {
        if (GetComponent<UpgradeDescription>()._greenBox == GetComponent<Button>().spriteState.disabledSprite)
            upgradeGotten = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!upgradeGotten)
        {
            tooltip2.SetActive(true);
            ToolTip1.SetActive(false);
        }
        else
            ToolTip1.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!upgradeGotten)
        {
            tooltip2.SetActive(false);
            ToolTip1.SetActive(false);
        }
        else
            ToolTip1.SetActive(false);

    }
}
