using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class craftItem : MonoBehaviour
{
    private Transform _craftingDisplay;
    private Sprite[] _receipe;
    private Sprite[] _crafting;
    private GameObject _outputSlot;
    private GameObject _playerInv;
    public GameObject _baseItem;

    private void Awake()
    {
        _craftingDisplay = GameObject.Find("craftingDisplay").transform;
        _outputSlot = GameObject.Find("outputSlot");
        _playerInv = GameObject.Find("playerInventory");
    }

    public void Craft()
    {
        craftingSystem();
    }

    public void Update()
    {

        GameObject _insItem = GameObject.Find("outItem");

        //receipe for ( BAG 1 )
        for (int i = 0; i < _craftingDisplay.childCount; i++)
        {
            if (_craftingDisplay.GetChild(i).GetComponent<Image>().sprite == global::ItemAssets.Instance.Fiber)
            {
                if (_craftingDisplay.GetChild(i + 1).GetComponent<Image>().sprite == global::ItemAssets.Instance.Fiber)
                {
                    if (_craftingDisplay.GetChild(i + 2).GetComponent<Image>().sprite == global::ItemAssets.Instance.Empty)
                    {
                        _insItem.GetComponent<Image>().sprite = global::ItemAssets.Instance.Bag;
                        break;
                    }
                }
            }
        }

        ////////////////////////////////////////////////////

        //receipe for ( BAG 2 )
        for (int i = 0; i < _craftingDisplay.childCount; i++)
        {
            if (_craftingDisplay.GetChild(i).GetComponent<Image>().sprite == global::ItemAssets.Instance.Empty)
            {
                if (_craftingDisplay.GetChild(i + 1).GetComponent<Image>().sprite == global::ItemAssets.Instance.Fiber)
                {
                    if (_craftingDisplay.GetChild(i + 2).GetComponent<Image>().sprite == global::ItemAssets.Instance.Fiber)
                    {
                        _insItem.GetComponent<Image>().sprite = global::ItemAssets.Instance.Bag;
                        break;
                    }
                }
            }
        }

        ////////////////////////////////////////////////////

        //receipe for ( Knfie )
        for (int i = 0; i < _craftingDisplay.childCount; i++)
        {
            if (_craftingDisplay.GetChild(i).GetComponent<Image>().sprite == global::ItemAssets.Instance.Bone)
            {
                if (_craftingDisplay.GetChild(i + 1).GetComponent<Image>().sprite == global::ItemAssets.Instance.Fiber)
                {
                    if (_craftingDisplay.GetChild(i + 2).GetComponent<Image>().sprite == global::ItemAssets.Instance.Wood)
                    {
                        _insItem.GetComponent<Image>().sprite = global::ItemAssets.Instance.Knife;
                        break;
                    }
                }
            }      
        }
        ////////////////////////////////////////////////////

        //receipe for ( Hatchet )
        for (int i = 0; i < _craftingDisplay.childCount; i++)
        {
            if (_craftingDisplay.GetChild(i).GetComponent<Image>().sprite == global::ItemAssets.Instance.Stone)
            {
                if (_craftingDisplay.GetChild(i + 1).GetComponent<Image>().sprite == global::ItemAssets.Instance.Fiber)
                {
                    if (_craftingDisplay.GetChild(i + 2).GetComponent<Image>().sprite == global::ItemAssets.Instance.Wood)
                    {
                        _insItem.GetComponent<Image>().sprite = global::ItemAssets.Instance.Hatchet;
                        break;
                    }
                }
            }
        }
        ////////////////////////////////////////////////////

        //receipe for ( Axe )
        for (int i = 0; i < _craftingDisplay.childCount; i++)
        {
            if (_craftingDisplay.GetChild(i).GetComponent<Image>().sprite == global::ItemAssets.Instance.Stone)
            {
                if (_craftingDisplay.GetChild(i + 1).GetComponent<Image>().sprite == global::ItemAssets.Instance.Hide)
                {
                    if (_craftingDisplay.GetChild(i + 2).GetComponent<Image>().sprite == global::ItemAssets.Instance.Wood)
                    {
                        _insItem.GetComponent<Image>().sprite = global::ItemAssets.Instance.Axe;
                        break;
                    }
                }
            }
        }
        ////////////////////////////////////////////////////

        //receipe for ( Pickaxe )
        for (int i = 0; i < _craftingDisplay.childCount; i++)
        {
            if (_craftingDisplay.GetChild(i).GetComponent<Image>().sprite == global::ItemAssets.Instance.Stone)
            {
                if (_craftingDisplay.GetChild(i + 1).GetComponent<Image>().sprite == global::ItemAssets.Instance.Stone)
                {
                    if (_craftingDisplay.GetChild(i + 2).GetComponent<Image>().sprite == global::ItemAssets.Instance.Wood)
                    {
                        _insItem.GetComponent<Image>().sprite = global::ItemAssets.Instance.Pickaxe;
                        break;
                    }
                }
            }
        }
        ////////////////////////////////////////////////////

        _insItem.GetComponent<Image>().sprite = global::ItemAssets.Instance.Empty;
 
    }

    public void craftingSystem()
    {
        //receipe for ( BAG 1 )
        for (int i = 0; i < _craftingDisplay.childCount; i++)
        {
            if(_craftingDisplay.GetChild(i).GetComponent<Image>().sprite == global::ItemAssets.Instance.Fiber)
            {
                if (_craftingDisplay.GetChild(i + 1).GetComponent<Image>().sprite == global::ItemAssets.Instance.Fiber)
                {
                    if (_craftingDisplay.GetChild(i + 2).GetComponent<Image>().sprite == global::ItemAssets.Instance.Empty)
                    {
                        GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
                        _insItem.GetComponent<CraftingInventory>()._itemName = "Bag";

                        int childCount = 0;
                        foreach (Transform item in _craftingDisplay.GetComponentInChildren<Transform>())
                        {

                            _craftingDisplay.GetChild(childCount).GetComponent<Image>().sprite = global::ItemAssets.Instance.Empty;
                            childCount++;
                            _playerInv.GetComponent<playerInventory>()._Bag = true;
                        }
                        break;
                    }
                }
            }
            break;
        }
        ////////////////////////////////////////////////////

        //receipe for ( BAG 2 )
        for (int i = 0; i < _craftingDisplay.childCount; i++)
        {
            if (_craftingDisplay.GetChild(i).GetComponent<Image>().sprite == global::ItemAssets.Instance.Empty)
            {
                if (_craftingDisplay.GetChild(i + 1).GetComponent<Image>().sprite == global::ItemAssets.Instance.Fiber)
                {
                    if (_craftingDisplay.GetChild(i + 2).GetComponent<Image>().sprite == global::ItemAssets.Instance.Fiber)
                    {
                        GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
                        _insItem.GetComponent<CraftingInventory>()._itemName = "Bag";

                        int childCount = 0;
                        foreach (Transform item in _craftingDisplay.GetComponentInChildren<Transform>())
                        {

                            _craftingDisplay.GetChild(childCount).GetComponent<Image>().sprite = global::ItemAssets.Instance.Empty;
                            childCount++;
                            _playerInv.GetComponent<playerInventory>()._Bag = true;
                        }
                        break;
                    }

                }
            }
            break;
        }
        ////////////////////////////////////////////////////

        //receipe for ( Knfie )
        for (int i = 0; i < _craftingDisplay.childCount; i++)
        {
            if (_craftingDisplay.GetChild(i).GetComponent<Image>().sprite == global::ItemAssets.Instance.Bone)
            {
                if (_craftingDisplay.GetChild(i + 1).GetComponent<Image>().sprite == global::ItemAssets.Instance.Fiber)
                {
                    if (_craftingDisplay.GetChild(i + 2).GetComponent<Image>().sprite == global::ItemAssets.Instance.Wood)
                    {
                        GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
                        _insItem.GetComponent<CraftingInventory>()._itemName = "Knife";

                        int childCount = 0;
                        foreach (Transform item in _craftingDisplay.GetComponentInChildren<Transform>())
                        {

                            _craftingDisplay.GetChild(childCount).GetComponent<Image>().sprite = global::ItemAssets.Instance.Empty;
                            childCount++;
                            _playerInv.GetComponent<playerInventory>()._Knife = true;
                        }
                        break;
                    }

                }
            }
            break;
        }
        ////////////////////////////////////////////////////
        
        //receipe for ( Hatchet )
        for (int i = 0; i < _craftingDisplay.childCount; i++)
        {
            if (_craftingDisplay.GetChild(i).GetComponent<Image>().sprite == global::ItemAssets.Instance.Stone)
            {
                if (_craftingDisplay.GetChild(i + 1).GetComponent<Image>().sprite == global::ItemAssets.Instance.Fiber)
                {
                    if (_craftingDisplay.GetChild(i + 2).GetComponent<Image>().sprite == global::ItemAssets.Instance.Wood)
                    {
                        GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
                        _insItem.GetComponent<CraftingInventory>()._itemName = "Hatchet";

                        int childCount = 0;
                        foreach (Transform item in _craftingDisplay.GetComponentInChildren<Transform>())
                        {

                            _craftingDisplay.GetChild(childCount).GetComponent<Image>().sprite = global::ItemAssets.Instance.Empty;
                            childCount++;
                            _playerInv.GetComponent<playerInventory>()._Hatchet = true;
                        }
                        break;
                    }

                }
            }
            break;
        }
        ////////////////////////////////////////////////////

        //receipe for ( Axe )
        for (int i = 0; i < _craftingDisplay.childCount; i++)
        {
            if (_craftingDisplay.GetChild(i).GetComponent<Image>().sprite == global::ItemAssets.Instance.Stone)
            {
                if (_craftingDisplay.GetChild(i + 1).GetComponent<Image>().sprite == global::ItemAssets.Instance.Hide)
                {
                    if (_craftingDisplay.GetChild(i + 2).GetComponent<Image>().sprite == global::ItemAssets.Instance.Wood)
                    {
                        GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
                        _insItem.GetComponent<CraftingInventory>()._itemName = "Axe";

                        int childCount = 0;
                        foreach (Transform item in _craftingDisplay.GetComponentInChildren<Transform>())
                        {

                            _craftingDisplay.GetChild(childCount).GetComponent<Image>().sprite = global::ItemAssets.Instance.Empty;
                            childCount++;
                            _playerInv.GetComponent<playerInventory>()._Axe = true;
                        }
                        break;
                    }

                }
            }
            break;
        }
        ////////////////////////////////////////////////////

        //receipe for ( Pickaxe )
        for (int i = 0; i < _craftingDisplay.childCount; i++)
        {
            if (_craftingDisplay.GetChild(i).GetComponent<Image>().sprite == global::ItemAssets.Instance.Stone)
            {
                if (_craftingDisplay.GetChild(i + 1).GetComponent<Image>().sprite == global::ItemAssets.Instance.Stone)
                {
                    if (_craftingDisplay.GetChild(i + 2).GetComponent<Image>().sprite == global::ItemAssets.Instance.Wood)
                    {
                        GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
                        _insItem.GetComponent<CraftingInventory>()._itemName = "Pickaxe";

                        int childCount = 0;
                        foreach (Transform item in _craftingDisplay.GetComponentInChildren<Transform>())
                        {

                            _craftingDisplay.GetChild(childCount).GetComponent<Image>().sprite = global::ItemAssets.Instance.Empty;
                            childCount++;
                            _playerInv.GetComponent<playerInventory>()._Picaxe = true;
                        }
                        break;
                    }

                }
            }
            break;
        }
        ////////////////////////////////////////////////////

    }

}
