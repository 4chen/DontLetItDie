using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class woodPile : MonoBehaviour
{
    public int amountOfwood;
    public GameObject wood, woodGameobject, campFire;

    public void Start()
    {
        woodGameobject = GameObject.Find("WoodPileAmount");
        campFire =       GameObject.Find("Campfire");
    }


    //remove 1 wood from pile and add to fire
    public void OnWoodClick()
    {
        if (amountOfwood > 0)
        {
            amountOfwood -= 1;
            campFire.GetComponent<Campfire>().add();
            updatehud();
        }
    }

    //add wood to wood pile
    public void AddWood(int modify)
    {
        amountOfwood += 1 + modify;
        updatehud();
    }

    //update the text for wood
    public void updatehud()
    {
        woodGameobject.GetComponent<Text>().text = amountOfwood.ToString();
    }

}
