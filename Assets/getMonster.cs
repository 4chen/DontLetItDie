using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getMonster : MonoBehaviour
{
    public GameObject forest;
    private playerInventory _playerInv;
    public Image _enemyImageIcon;
    public Image[] _enemyHealthIcon;
    public Image[] _playerHealthIcon;
    public Image[] _enemyDamagehIcon;
    public Image[] _playerDamageIcon;
    public int _foodCount;
    public GameObject _scratch;

    public int _playerDmg,_enemyDmg,_playerHealth,_enemyHealth;

    public void OnEnable()
    {
        _playerInv = GameObject.Find("playerInventory").GetComponent<playerInventory>();
        _playerHealth = _playerInv._playerHealth;
        createMonster();
    }

    public void createMonster()
    {
        for (int i = 0; i < 5; i++)
        {
            _playerHealthIcon[i].sprite = ItemAssets.Instance.EmptyHeart;
            _enemyHealthIcon[i].sprite = ItemAssets.Instance.EmptyHeart;
            _playerDamageIcon[i].sprite = ItemAssets.Instance.Empty;
            _enemyDamagehIcon[i].sprite = ItemAssets.Instance.Empty;
        }

        if (_playerInv._empty)
        {
            _enemyImageIcon.sprite = ItemAssets.Instance.Enemy_easy;
            _playerDmg = 1;
            monster(3);
        }
        if (_playerInv._Knife)
        {
            _enemyImageIcon.sprite = ItemAssets.Instance.Enemy_easy;
            _playerDmg = 2;
            monster(4);
        }
        if (_playerInv._Sword)
        {
            _enemyImageIcon.sprite = ItemAssets.Instance.Enemy_medium;
            _playerDmg = 3;
            monster(5);
        }
        if (_playerInv._Axe)
        {
            _enemyImageIcon.sprite = ItemAssets.Instance.Enemy_hard;
            _playerDmg = 4;
            monster(6);
        }

        _foodCount = _enemyHealth;
        updateGUI();
    }

    public void updateGUI()
    {
        //setup gui 
        for (int i = 0; i < 5; i++)
        {
            _playerHealthIcon[i].sprite = ItemAssets.Instance.EmptyHeart;
            _enemyHealthIcon[i].sprite = ItemAssets.Instance.EmptyHeart;
        }

        for (int i = 0; i < _playerHealth; i++)
        {
            _playerHealthIcon[i].sprite = ItemAssets.Instance.FullHeart;
        }
        for (int i = 0; i < _enemyHealth; i++)
        {
            _enemyHealthIcon[i].sprite = ItemAssets.Instance.FullHeart;
        }
        for (int i = 0; i < _playerDmg; i++)
        {
            _playerDamageIcon[i].sprite = ItemAssets.Instance.DamageIcon;
        }
        for (int i = 0; i < _enemyDmg; i++)
        {
            _enemyDamagehIcon[i].sprite = ItemAssets.Instance.DamageIcon;
        }
    }

    public void monster(int points)
    {
        _enemyDmg = Random.Range(1, points);
        points -= _enemyDmg;
        _enemyHealth = points;
    }

    public void StartBattle()
    {
        _playerHealth -= (_enemyDmg / 2);
        if((_enemyDmg / 2) > 0)
        {
            Instantiate(_scratch, GameObject.Find("PlayerPort").transform);
        }

        _enemyHealth -= _playerDmg;
        if (_playerDmg> 0)
        {
            Instantiate(_scratch, GameObject.Find("EnemyPort").transform);
        }
        _playerInv._playerHealth = _playerHealth;

        GameObject.Find("Health / timer").GetComponent<HealthAndTimerTEST>()._playerHealt();
        updateGUI();

        if(_enemyHealth <= 0)
        {
            forest.GetComponent<gather>().quitmenu();
            _playerInv.GetComponent<playerInventory>()._MeatCount += _foodCount;
        }
    }
}
