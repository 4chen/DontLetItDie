using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class craftingRecepise
{
    public List<Item> _itemList;

    //player inventory
    public craftingRecepise()
    { 
        _itemList = new List<Item>();
        addItem(new Item { _itemType = Item.ItemType.Fiber, _amount = 1 });
        addItem(new Item { _itemType = Item.ItemType.Stone, _amount = 1 });
        addItem(new Item { _itemType = Item.ItemType.Hide, _amount = 1 });
        addItem(new Item { _itemType = Item.ItemType.Bone, _amount = 1 });
        addItem(new Item { _itemType = Item.ItemType.Berry, _amount = 1 });
    }

    public void addItem(Item item)
    {
        _itemList.Add(item);
    }

    public List<Item> GetItemList()
    {
        return _itemList;
    }
}
