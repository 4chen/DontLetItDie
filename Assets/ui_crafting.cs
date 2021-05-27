using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_crafting : MonoBehaviour
{

    public Transform[] slotArray;
    public Transform outputSlot;

    private void Awake()
    {
        Transform gridCords = GameObject.Find("craftingDisplay").transform;

        slotArray = new Transform[3];

        for (int i = 0; i < 3; i++)
        {
            slotArray[i] = gridCords.Find("slot (" + i + ")");
        }

        outputSlot = GameObject.Find("outputSlot").transform;
    }

    private void creatItem(int pos, Item item)
    {

    }
}
