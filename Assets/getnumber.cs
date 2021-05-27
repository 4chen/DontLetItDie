using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getnumber : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = ((int)(GameObject.Find("Scrollbar").GetComponent<Scrollbar>().value * 10)).ToString();
    }
}
