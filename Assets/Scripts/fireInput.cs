using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class fireInput : MonoBehaviour, IDropHandler
{
    public Text _text;
    private int _woodInfire;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag.GetComponent<Image>().sprite.name == "Wood")
        {
            Debug.Log(eventData.pointerDrag.GetComponent<Image>().sprite.name);
            GameObject.Find("playerInventory").GetComponent<playerInventory>()._WoodCount--;
            _woodInfire++;
            GameObject.Find("Health / timer").GetComponent<HealthAndTimerTEST>()._addHelath();
        }
    }
}
