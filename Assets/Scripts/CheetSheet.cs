using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheetSheet : MonoBehaviour
{
    public GameObject Clock, meat, woodGameobject, pileOfWood, pauseMenu;
    public bool pasue;
    public int foodCount;

    public void Start()
    {
        Clock =          GameObject.Find("arm");
        meat =           GameObject.Find("cheatobject");
        pileOfWood =     GameObject.Find("woodPile");
        woodGameobject = GameObject.Find("WoodPileAmount");
        pauseMenu =      GameObject.Find("pauseMenu");

        updatehud();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pasue = !pasue;
            PauseTime(pasue);
        }

        pauseMenu.SetActive(pasue);
       if(pasue)
       {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
            }
       }
    }

    public void PauseTime(bool Pause)
    {
        if(Pause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    //update the amount of resourses that u have in the 
    public void updatehud()
    {           
        woodGameobject.GetComponent<Text>().text = pileOfWood.GetComponent<woodPile>().amountOfwood.ToString();
    }

    //speeds up clock
    public void AddTime(int Houers)
    {
        Clock.GetComponent<ClockCounter>().curentTime += 10 * Houers;
    }

    //add 1 wood to the woodpile
    public void GetWood()
    {
        pileOfWood.GetComponent<woodPile>().amountOfwood++;
        updatehud();

    }

    //remove 1 wood from the woodpile and add it to the campfire
    public void AddWoodToFire()
    {
        pileOfWood.GetComponent<woodPile>().amountOfwood--;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
