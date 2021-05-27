using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatherSlide : MonoBehaviour
{
    public float _sliderValue;
    public Scrollbar _Sbar;
    public Text _huntCount;

    public void Awake()
    {
        _sliderValue = _Sbar.value;
    }

    public void SubtractButton()
    {
        if (_Sbar.value > 0)
        {
            _sliderValue -= .1f;
            updateSlider();
        }
    }

    public void AddButton()
    {
        if(_Sbar.value < 1)
        {
            _sliderValue += .1f;
            updateSlider();
        }
    }

    public void updateSlider()
    {
        _Sbar.value = _sliderValue;
    }

    public void Update()
    {
        
       _huntCount.text = ((int)(_sliderValue * 10)).ToString();
    }
}
