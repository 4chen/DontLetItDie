﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial : MonoBehaviour
{
    public void OnStartGame()
    {
        SceneManager.LoadScene("map1");
    }
}
