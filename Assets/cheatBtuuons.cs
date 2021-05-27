using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheatBtuuons : MonoBehaviour
{
    public void CheatResourceReset()
    {
       var inv =  GameObject.Find("playerInventory").GetComponent<playerInventory>();

        inv._BoneCount = 2;
        inv._WoodCount = 2;
        inv._FiberCount = 2;
        inv._HideCount = 2;
        inv._StoneCount = 2;
    }
}
