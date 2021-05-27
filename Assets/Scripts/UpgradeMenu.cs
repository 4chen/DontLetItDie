using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpgradeMenu : MonoBehaviour
{
    public GameObject _UpgradeMenu, upScore, meatScore, woodScore, winMenu;
    bool openMenu;
    public int upgradePoints;
    public int WoodInc, MeatInc, woodUpCost = 3, meatUpCost = 3;

    public void Start()
    {
        upScore =   GameObject.Find("upScore");
        meatScore = GameObject.Find("meatScoreUp");
        woodScore = GameObject.Find("WoodScoreUp");
        winMenu =   GameObject.Find("WinMenu");

        winMenu.SetActive(false);
        _UpgradeMenu.SetActive(false);

        woodScore.GetComponent<Text>().text = woodUpCost.ToString();
        meatScore.GetComponent<Text>().text = meatUpCost.ToString();

    }

    public void Update()
    {
        upScore.GetComponent<Text>().text = upgradePoints.ToString();
        if(winMenu.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
            }
        }
    }

    public void OnUpgradeButton()
    {
        openMenu = !openMenu;

        if(openMenu)
        {
            _UpgradeMenu.SetActive(true);
        }
        else
        {
            _UpgradeMenu.SetActive(false);
        }
    }

    public void OnMeatIncButton()
    {
        if(upgradePoints >= meatUpCost)
        {
            upgradePoints -= meatUpCost;
            MeatInc++;
            meatUpCost++;
            meatScore.GetComponent<Text>().text = meatUpCost.ToString();
        }
    }

    public void OnWoodIncButton()
    {
        if(upgradePoints >= woodUpCost)
        {
            upgradePoints -= woodUpCost;
            WoodInc++;
            woodUpCost++;
            woodScore.GetComponent<Text>().text = woodUpCost.ToString();
        }
    }

    public void OnWinButton()
    {
        if(upgradePoints >= 15)
        {
            Time.timeScale = 0;
            winMenu.SetActive(true);
        }
    }
}
