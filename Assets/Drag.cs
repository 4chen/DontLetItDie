using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IPointerDownHandler,IDragHandler,IEndDragHandler,IPointerUpHandler
{
    private RectTransform _rt;
    private CanvasGroup _cg;
    public Canvas _canvas;
    private Vector2 _startPos;
    private GameObject _soundLib;

    public void Start()
    {
        _rt = GetComponent<RectTransform>();
        _cg = GetComponent<CanvasGroup>();
        _canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        _soundLib = GameObject.Find("SoundLibrary");
    }

    private void OnEnable()
    {
        if(_startPos == new Vector2(0,0))
        {
            _startPos = transform.position;
        }
        else
        {
            transform.position = _startPos;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            _rt.anchoredPosition += eventData.delta / _canvas.scaleFactor;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            transform.position = _startPos;
            _cg.blocksRaycasts = true;
            _cg.alpha = 1;
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            _soundLib.GetComponent<soundsLib>().audioPlay("OnClick");
            _startPos = transform.position;
            _cg.blocksRaycasts = false;
            _cg.alpha = .6f;       
        }
       
    }

    public void onClickItem()
    {
        Object.Destroy(this);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            _soundLib.GetComponent<soundsLib>().audioPlay("OnClick");
            transform.position = _startPos;
            _cg.blocksRaycasts = true;
            _cg.alpha = 1;
        }
    }
}
