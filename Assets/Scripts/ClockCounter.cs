using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockCounter : MonoBehaviour
{
    public int modifiedTime;
    public float curentTime;
    RectTransform rt;
    public GameObject HpGameobject, campFire, dayCount, dayCostWood;
    public int day, dayCost = 1;

    public void Start()
    {
        HpGameobject = GameObject.Find("HealthSystem");
        campFire =     GameObject.Find("Campfire");
        dayCount =     GameObject.Find("DayCount");
        dayCostWood =  GameObject.Find("cost");
        rt = GetComponent<RectTransform>();
    }

    void Update()
    {
            Clock();
    }

    public void Clock()
    {
        if (curentTime >= 360)
        {
            curentTime = 0;
            NewDay();
        }

        curentTime += modifiedTime * Time.deltaTime;

        rt.rotation = Quaternion.Euler(0, 0, -curentTime);
    }

    public void NewDay()
    {
        campFire.GetComponent<Campfire>().remove();
        day++;
        dayCount.GetComponent<Text>().text = day.ToString();
        HpGameobject.GetComponent<HP>().loseHp(1);     

        if(day % 2 == 0)
        {
            dayCost++;
            dayCostWood.GetComponent<Text>().text = "- " + dayCost.ToString();
        }
    }
}
