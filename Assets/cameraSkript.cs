using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSkript : MonoBehaviour
{

    private static cameraSkript _instance;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

    }
}
