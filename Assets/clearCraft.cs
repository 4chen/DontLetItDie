using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class clearCraft : MonoBehaviour
{
    private Transform _craftingDisplay;

    private void Awake()
    {
        _craftingDisplay = GameObject.Find("craftingDisplay").transform;
    }

    public void onClearCraft()
    {
        GameObject.Find("craftingDisplay").GetComponent<CraftingRecepieCheck>()._maxHp = false;

        int childCount = 0;
        foreach (Transform item in _craftingDisplay.GetComponentInChildren<Transform>())
        {

            switch (_craftingDisplay.GetChild(childCount).GetComponent<Image>().sprite.name)
            {
                default:
                    Debug.Log("unknown sprite : " + _craftingDisplay.GetChild(childCount).GetComponent<Image>().sprite.name);
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
                case ("Timer_13"):
                    Debug.Log("empty");
                    break;
            }



            _craftingDisplay.GetChild(childCount).GetComponent<Image>().sprite = ItemAssets.Instance.Empty;
            childCount++;            
        } 
    }

}
