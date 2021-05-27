using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFood : MonoBehaviour
{
    GameObject HpGameobject,Clock;

    public void Start()
    {
        HpGameobject = GameObject.Find("HealthSystem");
        Clock = GameObject.Find("arm");
    }

    public void OnMeatClick()
    {
        HpGameobject.GetComponent<HP>().GainHp(1);
    }

    public void OnDoActionClick()
    {
        Clock.GetComponent<ClockCounter>().curentTime += 20;
    }
}
