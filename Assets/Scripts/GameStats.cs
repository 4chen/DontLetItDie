using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStats : MonoBehaviour
{
    public int woodCount;
    public int meatCount;

    public GameObject woodDisp;
    public GameObject meatDisp;

    public void Start()
    {
        woodDisp = GameObject.Find("WoodAmount");
        meatDisp = GameObject.Find("FoodAmount");
    }
}
