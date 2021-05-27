using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public int HitPoints;
    int maxHitPoints = 5;
    public GameObject[] hitBars;
    public Sprite OneHpBar, ZeroHpBar;
    public GameObject gameOverScreen;


    private void Start()
    {
        gameOverScreen = GameObject.Find("GameOver");
        gameOverScreen.SetActive(false);
        UpdateHpBar();
    } 

    public void UpdateHpBar()
    {
        for (int i = 0; i < hitBars.Length; i++)
        {
            hitBars[i] = transform.GetChild(i).gameObject;

            if(i + 1 <= HitPoints)
            {
                hitBars[i].GetComponent<Image>().sprite = OneHpBar;
            }
            else
            {
                hitBars[i].GetComponent<Image>().sprite = ZeroHpBar;
            }
        }
    }

    public void loseHp(int hpLoss)
    {
        HitPoints -= hpLoss;
        UpdateHpBar();
        if (HitPoints <= 0)
        {
            GameOver();
        }
    }

    public void GainHp(int HpGain)
    {
        if(HitPoints < maxHitPoints)
        {
            HitPoints += HpGain;
            UpdateHpBar();
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);
    }
}
