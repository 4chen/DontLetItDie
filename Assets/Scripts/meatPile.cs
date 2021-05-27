using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class meatPile : MonoBehaviour
{
    public int foodCount;
    public GameObject meat, HpGameobject, foodGameobject;

    public void Start()
    {
        HpGameobject =   GameObject.Find("HealthSystem");
        foodGameobject = GameObject.Find("FoodAmount");
    }


    //eat 1 food to get 1 health
    public void OnMeatClick()
    {
        if (foodCount > 0)
        {
            HpGameobject.GetComponent<HP>().GainHp(1);
            foodCount -= 1;
            updatehud();
        }
    }

    public void AddMeat(int modify)
    {
        foodCount += 1 + modify;
        updatehud();
    }

    //update the text for food
    public void updatehud()
    {
        foodGameobject.GetComponent<Text>().text = foodCount.ToString();
    }
}
