using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class test : MonoBehaviour
{

    private void Start()
    {
        craftingStation craftSystem = new craftingStation();
        Item _item = new Item { _itemType = Item.ItemType.Wood, _amount = 1 };
        Item _item1 = new Item { _itemType = Item.ItemType.Stone, _amount = 1 };
        Item _item2 = new Item { _itemType = Item.ItemType.Knife, _amount = 1 };

        craftSystem.setItem(_item, 0);
        craftSystem.setItem(_item1, 1);
        craftSystem.setItem(_item2, 2);

        for (int i = 0; i < 3; i++)
        {


        }
    }
}
