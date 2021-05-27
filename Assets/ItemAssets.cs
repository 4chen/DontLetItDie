using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite Bag;
    public Sprite Knife;
    public Sprite Hatchet;
    public Sprite Axe;
    public Sprite Pickaxe;
    public Sprite Wood;
    public Sprite Fiber;
    public Sprite Bone;
    public Sprite Hide;
    public Sprite Stone;
    public Sprite Meat;
    public Sprite CokkedMeat;
    public Sprite Berry;
    public Sprite CokkedBerry;
    public Sprite Empty;
    public Sprite Sword;
    public Sprite Enemy_easy;
    public Sprite Enemy_medium;
    public Sprite Enemy_hard;
    public Sprite FullHeart;
    public Sprite EmptyHeart;
    public Sprite DamageIcon;
    public Sprite Point;
}
