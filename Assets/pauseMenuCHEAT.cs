using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseMenuCHEAT : MonoBehaviour
{
    public Sprite[] pUnp;
    private bool isPused;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            isPused = !isPused;
        }

        var _hNt = GameObject.Find("Health / timer");

        if(_hNt.GetComponent<HealthAndTimerTEST>()._endstate)
        {
            isPused = true;
        }

        if (isPused)
        {
            GetComponent<Image>().sprite = pUnp[1];
            Time.timeScale = 0;
        }
        else
        {
            GetComponent<Image>().sprite = pUnp[0];
            Time.timeScale = 1;
        }
    }

    public void buttonPause()
    {
        isPused = !isPused;
    }
}
