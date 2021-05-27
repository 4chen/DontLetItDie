using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CraftingRecepieCheck : MonoBehaviour
{
    public global::ItemAssets[] recipe;
    public bool recipeFound;
    public GameObject _baseItem;
    private Transform _craftingDisplay;
    private GameObject _outputSlot;
    private GameObject _playerInv;
    private Image _outIcon;
    private GameObject _soundLib;
    public bool _maxHp;
    public Font myFont;

    public void Awake()
    {
        _craftingDisplay = GameObject.Find("craftingDisplay").transform;
        _outputSlot = GameObject.Find("outputSlot");
        _playerInv = GameObject.Find("playerInventory");
        _outIcon = GameObject.Find("outItem").GetComponent<Image>();
        _soundLib = GameObject.Find("SoundLibrary");
    }

    public void crafting()
    {
        if (CheckRecipe(ItemAssets.Instance.Fiber, ItemAssets.Instance.Fiber))
        {
            GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
            _insItem.GetComponent<CraftingInventory>()._itemName = "Bag";
            _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
            emptySlot();
        }
        if (CheckRecipe(ItemAssets.Instance.Stone, ItemAssets.Instance.Fiber, ItemAssets.Instance.Wood))
        {
            if (_playerInv.GetComponent<playerInventory>()._Hatchetrecepi)
            {
                GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
                _insItem.GetComponent<CraftingInventory>()._itemName = "Hatchet";
                _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
                emptySlot();
            }
        }
        if (CheckRecipe(ItemAssets.Instance.Stone, ItemAssets.Instance.Stone, ItemAssets.Instance.Wood))
        {
            if (_playerInv.GetComponent<playerInventory>()._Axerecepi)
            {
                GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
                _insItem.GetComponent<CraftingInventory>()._itemName = "Axe";
                _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
                emptySlot();
            }
        }
        if (CheckRecipe(ItemAssets.Instance.Stone, ItemAssets.Instance.Hide, ItemAssets.Instance.Wood))
        {
            if (_playerInv.GetComponent<playerInventory>()._Pickaxerecepi)
            {
                GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
                _insItem.GetComponent<CraftingInventory>()._itemName = "Pickaxe";
                _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
                emptySlot();
            }
        }
        if (CheckRecipe(ItemAssets.Instance.Stone, ItemAssets.Instance.Bone, ItemAssets.Instance.Wood))
        {
            if (_playerInv.GetComponent<playerInventory>()._Knfierecepi)
            {
                GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
                _insItem.GetComponent<CraftingInventory>()._itemName = "Knife";
                _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
                emptySlot();
            }
        }
        if (CheckRecipe(ItemAssets.Instance.Stone, ItemAssets.Instance.Wood, ItemAssets.Instance.Wood))
        {
            if (_playerInv.GetComponent<playerInventory>()._Swordrecepi)
            {
                GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
                _insItem.GetComponent<CraftingInventory>()._itemName = "Sword";
                _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
                emptySlot();
            }
        }
        if (CheckRecipe(ItemAssets.Instance.Stone, ItemAssets.Instance.Wood, ItemAssets.Instance.Meat))
        {
            GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
            _insItem.GetComponent<CraftingInventory>()._itemName = "Point";
            _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
            emptySlot();
        }
        if (CheckRecipe(ItemAssets.Instance.Meat, ItemAssets.Instance.Meat))
        {
            if (_playerInv.GetComponent<playerInventory>()._Meatrecepi)
            {
                if (_playerInv.GetComponent<playerInventory>()._playerHealth < 5)
                {
                    GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
                    _insItem.GetComponent<CraftingInventory>()._itemName = "FullHeart";
                    _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
                    emptySlot();
                }

            }
        }
        if (CheckRecipe(ItemAssets.Instance.Berry, ItemAssets.Instance.Berry,ItemAssets.Instance.Berry))
        {
            if (_playerInv.GetComponent<playerInventory>()._Berryrecepi)
            {
                if (_playerInv.GetComponent<playerInventory>()._playerHealth < 5)
                {
                    GameObject _insItem = Instantiate(_baseItem, _outputSlot.transform);
                    _insItem.GetComponent<CraftingInventory>()._itemName = "FullHeart";
                    _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
                    emptySlot();
                }
            }
        }
    }

    public void canCraft()
    {
        if (CheckRecipe(ItemAssets.Instance.Empty, ItemAssets.Instance.Empty, ItemAssets.Instance.Empty))
        {
            _outIcon.sprite = ItemAssets.Instance.Empty;
        }
        if (CheckRecipe(ItemAssets.Instance.Fiber, ItemAssets.Instance.Fiber))
        {           
            _outIcon.sprite = ItemAssets.Instance.Bag;
        }
        if (CheckRecipe(ItemAssets.Instance.Stone, ItemAssets.Instance.Fiber, ItemAssets.Instance.Wood))
        {
            if(_playerInv.GetComponent<playerInventory>()._Hatchetrecepi)
            _outIcon.sprite = ItemAssets.Instance.Hatchet;
        }
        if (CheckRecipe(ItemAssets.Instance.Stone, ItemAssets.Instance.Stone, ItemAssets.Instance.Wood))
        {
            if (_playerInv.GetComponent<playerInventory>()._Axerecepi)
                _outIcon.sprite = ItemAssets.Instance.Axe;
        }
        if (CheckRecipe(ItemAssets.Instance.Stone, ItemAssets.Instance.Hide, ItemAssets.Instance.Wood))
        {
            if (_playerInv.GetComponent<playerInventory>()._Pickaxerecepi)
            _outIcon.sprite = ItemAssets.Instance.Pickaxe;
        }
        if (CheckRecipe(ItemAssets.Instance.Stone, ItemAssets.Instance.Bone, ItemAssets.Instance.Wood))
        {
            if (_playerInv.GetComponent<playerInventory>()._Knfierecepi)
                _outIcon.sprite = ItemAssets.Instance.Knife;
        }
        if (CheckRecipe(ItemAssets.Instance.Stone, ItemAssets.Instance.Wood, ItemAssets.Instance.Wood))
        {
            if (_playerInv.GetComponent<playerInventory>()._Swordrecepi)
                _outIcon.sprite = ItemAssets.Instance.Sword;
        }
        if (CheckRecipe(ItemAssets.Instance.Stone, ItemAssets.Instance.Wood, ItemAssets.Instance.Meat))
        {
                _outIcon.sprite = ItemAssets.Instance.Point;
        }
        if (CheckRecipe(ItemAssets.Instance.Meat, ItemAssets.Instance.Meat))
        {
            if (_playerInv.GetComponent<playerInventory>()._Meatrecepi)
            {
                if (_playerInv.GetComponent<playerInventory>()._playerHealth < 5)
                {
                    _outIcon.sprite = ItemAssets.Instance.FullHeart;
                }
                else
                {
                    _maxHp = true;
                }
            }
        }
        if (CheckRecipe(ItemAssets.Instance.Berry, ItemAssets.Instance.Berry, ItemAssets.Instance.Berry))
        {
            if (_playerInv.GetComponent<playerInventory>()._Berryrecepi)
            {
                if (_playerInv.GetComponent<playerInventory>()._playerHealth < 5)
                {
                    _outIcon.sprite = ItemAssets.Instance.FullHeart;
                }
                else
                {
                    _maxHp = true;
                }
            }
        }

        if (!CheckRecipe(ItemAssets.Instance.Berry, ItemAssets.Instance.Berry, ItemAssets.Instance.Berry) && !CheckRecipe(ItemAssets.Instance.Meat, ItemAssets.Instance.Meat))
        {
            _maxHp = false;
        }
    }

    void OnGUI()
    {
        var myGuiStyle = GUI.skin.GetStyle("Label");
        myGuiStyle.alignment = TextAnchor.UpperCenter;
        myGuiStyle.font = myFont;
        myGuiStyle.fontSize = 20; 

        if (_maxHp)
        GUI.TextField(new Rect((Screen.width / 2) - 50, Screen.height / 2, 200, 100), "You're on max HP",myGuiStyle);
    }

    public void emptySlot()
    {
        int childCount = 0;
        foreach (Image item in gameObject.GetComponentsInChildren<Image>())
        {
            if (item.transform == transform)
                continue;

            _craftingDisplay.GetChild(childCount).GetComponent<Image>().sprite = global::ItemAssets.Instance.Empty;
            childCount++;          
        }
    }

    private bool CheckRecipe(params Sprite[] ingredients)
    {
        
        int foundIngredients = 0;
        bool recipeFound = false;

        foreach (var slot in _craftingDisplay.GetComponentsInChildren<Image>())
        {
            if (slot.transform == transform)
                continue;
            if (recipeFound)
            {
                if (slot.GetComponent<Image>().sprite != ItemAssets.Instance.Empty)
                    recipeFound = false;
                break;
            }

            if (slot.GetComponent<Image>().sprite == ingredients[foundIngredients])
                foundIngredients++;
               
            else if (slot.GetComponent<Image>().sprite != ItemAssets.Instance.Empty)
            {
                foundIngredients = 0;
                break;
            }

            if (foundIngredients == ingredients.Length)
                recipeFound = true;
        }
        if (recipeFound)
            return true;

        return false;
    }

    public void Update()
    {
        canCraft();
    }
}
