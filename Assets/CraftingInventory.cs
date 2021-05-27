using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingInventory : MonoBehaviour
{
    public string _itemName;
    private bool _update;
    private GameObject _playerInv;
    public string _buff;

    public void OnEnable()
    {
        _update = true;
    }

    public void OnDisable()
    {
        _update = false;
    }

    private void Update()
    {
        if(_update)
        {
            insiteliseCrafting();
        }

    }

    public void insiteliseCrafting()
    {
        _playerInv = GameObject.Find("playerInventory");

        switch (_itemName)
        {
            default:
                GetComponent<Image>().sprite = ItemAssets.Instance.Empty;
                break;
            case ("Wood"):
                   
                if(GameObject.Find("playerInventory").GetComponent<playerInventory>()._WoodCount > 0)
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Wood;
                    GetComponentInChildren<Text>().text = GameObject.Find("playerInventory").GetComponent<playerInventory>()._WoodCount.ToString();
                }
                else
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Empty;
                    GetComponentInChildren<Text>().text = "";
                }
                break;
            case ("Stone"):
                if (GameObject.Find("playerInventory").GetComponent<playerInventory>()._StoneCount > 0)
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Stone;
                    GetComponentInChildren<Text>().text = GameObject.Find("playerInventory").GetComponent<playerInventory>()._StoneCount.ToString();
                }
                else
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Empty;
                    GetComponentInChildren<Text>().text = "";
                }
                break;
            case ("Fiber"):
                if (GameObject.Find("playerInventory").GetComponent<playerInventory>()._FiberCount > 0)
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Fiber;
                    GetComponentInChildren<Text>().text = GameObject.Find("playerInventory").GetComponent<playerInventory>()._FiberCount.ToString();
                }
                else
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Empty;
                    GetComponentInChildren<Text>().text = "";
                }
                break;
            case ("Hide"):
                if (GameObject.Find("playerInventory").GetComponent<playerInventory>()._HideCount > 0)
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Hide;
                    GetComponentInChildren<Text>().text = GameObject.Find("playerInventory").GetComponent<playerInventory>()._HideCount.ToString();
                }
                else
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Empty;
                    GetComponentInChildren<Text>().text = "";
                }
                break;
            case ("Bone"):
                if (GameObject.Find("playerInventory").GetComponent<playerInventory>()._BoneCount > 0)
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Bone;
                    GetComponentInChildren<Text>().text = GameObject.Find("playerInventory").GetComponent<playerInventory>()._BoneCount.ToString();
                }
                else
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Empty;
                    GetComponentInChildren<Text>().text = "";
                }
                break;
            case ("Berry"):
                if (GameObject.Find("playerInventory").GetComponent<playerInventory>()._berryCount > 0)
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Berry;
                    GetComponentInChildren<Text>().text = GameObject.Find("playerInventory").GetComponent<playerInventory>()._berryCount.ToString();
                }
                else
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Empty;
                    GetComponentInChildren<Text>().text = "";
                }
                break;
            case ("Meat"):
                if (GameObject.Find("playerInventory").GetComponent<playerInventory>()._MeatCount > 0)
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Meat;
                    GetComponentInChildren<Text>().text = GameObject.Find("playerInventory").GetComponent<playerInventory>()._MeatCount.ToString();
                }
                else
                {
                    GetComponent<Image>().sprite = ItemAssets.Instance.Empty;
                    GetComponentInChildren<Text>().text = "";
                }
                break;
            case ("Bag"):
                GetComponent<Image>().sprite = ItemAssets.Instance.Bag;
                break;
            case ("Knife"):
                GetComponent<Image>().sprite = ItemAssets.Instance.Knife;
                break;
            case ("Hatchet"):
                GetComponent<Image>().sprite = ItemAssets.Instance.Hatchet;
                break;
            case ("Axe"):
                GetComponent<Image>().sprite = ItemAssets.Instance.Axe;
                break;
            case ("Pickaxe"):
                GetComponent<Image>().sprite = ItemAssets.Instance.Pickaxe;
                break;
            case ("Sword"):
                GetComponent<Image>().sprite = ItemAssets.Instance.Sword;
                break;
            case ("Point"):
                GetComponent<Image>().sprite = ItemAssets.Instance.Point;
                break;
            case ("FullHeart"):
                GetComponent<Image>().sprite = ItemAssets.Instance.FullHeart;
                break;

        }
    }

    public void OnClickItem()
    {
        switch (_itemName)
        {
            case ("Bag"):
                _playerInv.GetComponent<playerInventory>()._Bag = true;
                break;
            case ("Hatchet"):
                _playerInv.GetComponent<playerInventory>()._Hatchet = true;
                break;
            case ("Axe"):
                _playerInv.GetComponent<playerInventory>()._Axe = true;
                break;
            case ("Pickaxe"):
                _playerInv.GetComponent<playerInventory>()._Picaxe = true;
                break;
            case ("Knife"):
                _playerInv.GetComponent<playerInventory>()._Knife = true;
                break;
            case ("Sword"):
                _playerInv.GetComponent<playerInventory>()._Sword = true;
                break;
            case ("Point"):
                _playerInv.GetComponent<playerInventory>()._UpgradePoints += 1;
                break;
            case ("FullHeart"):
                _playerInv.GetComponent<playerInventory>()._playerHealth += 1;
                GameObject.Find("Health / timer").GetComponent<HealthAndTimerTEST>()._playerHealt();
                break;


                
        }
        Destroy(gameObject);
    }
}
