using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthAndTimerTEST : MonoBehaviour
{
    public Image _hpBar, _timerBar;
    public float _hp, _time, _curentTime, _modifiedTime;
    public GameObject _endMenu;
    public bool _endstate;
    public int _playerHp;
    public GameObject[] _hearts;

    public void Start()
    {
        _healthUpdate();
    }

    void Update()
    {


        if(_curentTime < 0)
        {
            _curentTime = 1;
            _hp -= .1f;
            _healthUpdate();
            GameObject.Find("playerInventory").GetComponent<playerInventory>()._playerHealth--;
            _playerHealt();
            if (_hp < 0)
            {
                _gameover();
            }
        }
        _Time();

        if(_endstate)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Time.timeScale = 1;
                _endstate = false;
                SceneManager.LoadScene("map1");

            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                Time.timeScale = 1;
                _endstate = false;
                SceneManager.LoadScene("Insturctions");

            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
                Time.timeScale = 1;
                _endstate = false;

            }
        }
    }

    public void _playerHealt()
    {
        var playerHealth = GameObject.Find("playerInventory").GetComponent<playerInventory>()._playerHealth;

        for (int i = 0; i < 5; i++)
        {
            _hearts[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < playerHealth; i++)
        {
            _hearts[i].gameObject.SetActive(true);
        }

        if (playerHealth <= 0)
            _gameover();

    }

    public void _addHelath()
    {
        _hp += .1f;
        _healthUpdate();
    }

    public void _healthUpdate()
    {
        _hpBar.fillAmount = _hp;
    }

    public void _Time()
    {
        _modifiedTime = GameObject.Find("playerInventory").GetComponent<playerInventory>()._TimeModifier;
        _curentTime -= _modifiedTime * Time.deltaTime;
        _timerBar.fillAmount = _curentTime;     
    }

    public void _gameover()
    {
        Time.timeScale = 0;
        _endMenu.SetActive(true);
        _endMenu.GetComponentInChildren<Text>().text = "GameOver your fire ran out of wood \n [R] to  quick restart \n [M] to main menu \n [esc] to quit";
        _endstate = true;
    }

    public void _vicotry()
    {
        Time.timeScale = 0;
        _endMenu.SetActive(true);
        _endMenu.GetComponentInChildren<Text>().text = "Victory your fire is the bigest ;) \n [R] to  quick restart \n [M] to main menu \n [esc] to quit";
        _endstate = true;
    }
}
