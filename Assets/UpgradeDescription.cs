using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeDescription : MonoBehaviour
{
    public GameObject _playerInv;
    private int cost;
    public GameObject _nextUpgrade;
    public Sprite _menuDark, _menuLight, _greenBox;
    public bool _isActive;
    public bool _isFinall;
    public string _recepies;

    public void Start()
    {
        _playerInv = GameObject.Find("playerInventory");
        cost = int.Parse(transform.Find("points").transform.Find("cost").GetComponent<Text>().text);


    }

    public void Update()
    {
        if(_isActive)
        {
            GetComponent<Image>().sprite = _menuLight;
        }
        else
        {
            GetComponent<Image>().sprite = _menuDark;
        }
    }

    public void buyUpgrade()
    {

        if (_playerInv.GetComponent<playerInventory>()._UpgradePoints >= cost)
        {
            if (_isFinall)
            {
                GameObject.Find("Health / timer").GetComponent<HealthAndTimerTEST>()._vicotry();
            }
            _playerInv.GetComponent<playerInventory>()._UpgradePoints = _playerInv.GetComponent<playerInventory>()._UpgradePoints - cost;

            switch (_recepies)
            {

                case ("Berry"):
                    _playerInv.GetComponent<playerInventory>()._Berryrecepi = true;
                    break;
                case ("Meat"):
                    _playerInv.GetComponent<playerInventory>()._Meatrecepi = true;
                    break;
                case ("Pickaxe"):
                    _playerInv.GetComponent<playerInventory>()._Pickaxerecepi = true;
                    break;
                case ("Axe"):
                    _playerInv.GetComponent<playerInventory>()._Axerecepi = true;
                    break;
                case ("Sword"):
                    _playerInv.GetComponent<playerInventory>()._Swordrecepi = true;
                    break;
                case ("Hatchet"):
                    _playerInv.GetComponent<playerInventory>()._Hatchetrecepi = true;
                    break;
                case ("Energy"):
                    _playerInv.GetComponent<playerInventory>()._TimeModifier = _playerInv.GetComponent<playerInventory>()._TimeModifier / 2;
                    break;
                default:
                    break;
            }

            _nextUpgrade.GetComponent<UpgradeDescription>()._isActive = true;
            GetComponent<UpgradeDescription>()._isActive = false;
            _nextUpgrade.GetComponent<Button>().interactable = true;
            var spritState = GetComponent<Button>().spriteState;

            spritState.disabledSprite = _greenBox;
            GetComponent<Button>().spriteState = spritState;

            GetComponent<Button>().interactable = false;

        }
    }
}
