using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FireTask : MonoBehaviour, IPointerUpHandler,IPointerDownHandler,IBeginDragHandler,IEndDragHandler,IDragHandler
{
    private RectTransform _rt;
    [SerializeField]
    private CanvasGroup _cg;

    private bool _gotWood;
    public Text _woodDisplayCount;
    private playerInventory _inv;
    private Canvas _canvas;
    private GameObject _soundLib;

    private Vector2 _startPos;

    public void OnEnable()
    {
        _inv = GameObject.Find("playerInventory").GetComponent<playerInventory>();
        _soundLib = GameObject.Find("SoundLibrary");
        woodCheck();
    }

    private void Start()
    {
        _rt = GetComponent<RectTransform>();
        _cg = GetComponent<CanvasGroup>();
        _canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        woodCheck();
    }

    public void woodCheck()
    {
        if (_inv._WoodCount > 0)
        {
            _gotWood = true;
            _cg.alpha = 1;
            _cg.blocksRaycasts = true;
        }
        else
        {
            _gotWood = false;
            _cg.alpha = 0;
            _cg.blocksRaycasts = false;
        }
        _woodDisplayCount.text = _inv._WoodCount.ToString();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if(_gotWood)
        {
            _cg.alpha = .6f;
            _cg.blocksRaycasts = false;
            _woodDisplayCount.text = _inv._WoodCount.ToString();
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if(_gotWood)
        {
            _cg.alpha = 1;
            _cg.blocksRaycasts = true;
            transform.position = _startPos;
            woodCheck();
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(_gotWood)
        {
            _rt.anchoredPosition += eventData.delta / _canvas.scaleFactor;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _soundLib.GetComponent<soundsLib>().audioPlay("OnClick");
        if (_gotWood)
        {
            _startPos = transform.position;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _soundLib.GetComponent<soundsLib>().audioPlay("OnClick");
    }
}
