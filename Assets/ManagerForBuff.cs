using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerForBuff : MonoBehaviour
{
    public Toggle[] _buffBox;
    private GameObject _soundLib;

    public void Start()
    {
        _soundLib = GameObject.Find("SoundLibrary");
    }

    void Update()
    {

        for (int i = 0; i < _buffBox.Length; i++)
        {
            if(_buffBox[i].GetComponent<Toggle>().isOn)
            {
                GameObject.Find("menu(gather) (experimental)").GetComponent<gathering>().Validate(_buffBox[i].name);
                break;
            }
            if(i == 3)
            {
                GameObject.Find("menu(gather) (experimental)").GetComponent<gathering>().Validate("none");
            }
        }
    }
}
