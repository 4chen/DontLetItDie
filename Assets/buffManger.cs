using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buffManger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject _toolTip;
    public GameObject _playerInv;
    public bool _bag, _hatchet, _pickaxe, _empty;
    public string _buttonName;
    private CanvasGroup _cg;

    public void OnEnable()
    {
        playerInventory pi = _playerInv.GetComponent<playerInventory>();
        _cg = GetComponent<CanvasGroup>();

        _empty = pi._empty;
        _bag = pi._Bag;
        _hatchet = pi._Hatchet;
        _pickaxe = pi._Picaxe;

        //if you have the item or not
        switch (_buttonName)
        {
            case ("empty"):
                if (!_empty)
                {
                    _cg.alpha = 0;
                }
                else
                {
                    _cg.alpha = 1;
                }
                break;

            case ("bag"):
                if(!_bag)
                {
                    _cg.alpha = 0;
                }
                else
                {
                    _cg.alpha = 1;
                }
                break;

            case ("hatchet"):
                if(!_hatchet)
                {
                    _cg.alpha = 0;
                }
                else
                {
                    _cg.alpha = 1;
                }
                break;

            case ("pickaxe"):
                if(!_pickaxe)
                {
                    _cg.alpha = 0;
                }
                else
                {
                    _cg.alpha = 1;
                }
                break;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _toolTip.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _toolTip.SetActive(false);
    }
}
