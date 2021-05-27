using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Item
{
    public enum ItemType
    {
        Bag,
        Knife,
        Hatchet,
        Axe,
        Wood,
        Stone,
        Bone,
        Fiber,
        Hide,
        Berry,
        CokkedBerry,
        Meat,
        CokkedMeat,
        UpgradePoints,

    }

    public ItemType _itemType;
    public int _amount;
    
    public Sprite GetSprite()
    {
        switch (_itemType)
        {
            default:
            case ItemType.Bag:          return ItemAssets.Instance.Bag;
            case ItemType.Knife:        return ItemAssets.Instance.Knife;
            case ItemType.Hatchet:      return ItemAssets.Instance.Hatchet;
            case ItemType.Axe:          return ItemAssets.Instance.Axe;
            case ItemType.Stone:        return ItemAssets.Instance.Stone;
            case ItemType.Wood:         return ItemAssets.Instance.Wood;
            case ItemType.Bone:         return ItemAssets.Instance.Bone;
            case ItemType.Fiber:        return ItemAssets.Instance.Fiber;
            case ItemType.Hide:         return ItemAssets.Instance.Hide;
            case ItemType.Berry:        return ItemAssets.Instance.Berry;
            case ItemType.CokkedBerry:  return ItemAssets.Instance.CokkedBerry;
            case ItemType.Meat:         return ItemAssets.Instance.Meat;
            case ItemType.CokkedMeat:   return ItemAssets.Instance.CokkedMeat;
        }
    }
}
