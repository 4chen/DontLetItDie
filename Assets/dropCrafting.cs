using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dropCrafting : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {

            if(GetComponent<Image>().sprite.name == "Timer_13")
            {
                GetComponent<Image>().sprite = eventData.pointerDrag.GetComponent<Image>().sprite;
            }
            else
            {
                switch (GetComponent<Image>().sprite.name)
                {
                    default:
                        Debug.Log("unknown sprite : " + eventData.pointerDrag.GetComponent<Image>().sprite.name);
                        break;

                    case ("Wood"):
                        GameObject.Find("playerInventory").GetComponent<playerInventory>()._WoodCount++;
                        break;
                    case ("Stone"):
                        GameObject.Find("playerInventory").GetComponent<playerInventory>()._StoneCount++;
                        break;
                    case ("Fiber"):
                        GameObject.Find("playerInventory").GetComponent<playerInventory>()._FiberCount++;
                        break;
                    case ("Hide"):
                        GameObject.Find("playerInventory").GetComponent<playerInventory>()._HideCount++;
                        break;
                    case ("Bone"):
                        GameObject.Find("playerInventory").GetComponent<playerInventory>()._BoneCount++;
                        break;
                    case ("Meat"):
                        GameObject.Find("playerInventory").GetComponent<playerInventory>()._MeatCount++;
                        break;
                    case ("Berry"):
                        GameObject.Find("playerInventory").GetComponent<playerInventory>()._berryCount++;
                        break;

                }
                GetComponent<Image>().sprite = eventData.pointerDrag.GetComponent<Image>().sprite;
            }

            switch (eventData.pointerDrag.GetComponent<Image>().sprite.name)
            {
                default:
                    Debug.Log("unknown sprite : " + eventData.pointerDrag.GetComponent<Image>().sprite.name);
                    break;

                case ("Wood"):
                    GameObject.Find("playerInventory").GetComponent<playerInventory>()._WoodCount--;
                    break;
                case ("Stone"):
                    GameObject.Find("playerInventory").GetComponent<playerInventory>()._StoneCount--;
                    break;
                case ("Fiber"):
                    GameObject.Find("playerInventory").GetComponent<playerInventory>()._FiberCount--;
                    break;
                case ("Hide"):
                    GameObject.Find("playerInventory").GetComponent<playerInventory>()._HideCount--;
                    break;
                case ("Bone"):
                    GameObject.Find("playerInventory").GetComponent<playerInventory>()._BoneCount--;
                    break;
                case ("Meat"):
                    GameObject.Find("playerInventory").GetComponent<playerInventory>()._MeatCount--;
                    break;
                case ("Berry"):
                    GameObject.Find("playerInventory").GetComponent<playerInventory>()._berryCount--;
                    break;
            }
        }
    }
}
