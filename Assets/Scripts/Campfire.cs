using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Campfire : MonoBehaviour
{

    public int woodInFire;
    public GameObject woodFireText, ClockC, HpGameobject;

    public void Start()
    {
        woodFireText = GameObject.Find("WoodAmount");
        ClockC =       GameObject.Find("arm");
        HpGameobject = GameObject.Find("HealthSystem");
        woodFireText.GetComponent<Text>().text = woodInFire.ToString();
    }

    public void add()
    {
        woodInFire += 1;

        updateText();
    }

    public void remove()
    {
        woodInFire -= ClockC.GetComponent<ClockCounter>().dayCost;

        updateText();

        if (woodInFire <= 0)
        {
            HpGameobject.GetComponent<HP>().GameOver();
        }

    }

    public void updateText()
    {
        woodFireText.GetComponent<Text>().text = woodInFire.ToString();
    }
}
