using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cooldowntimer : MonoBehaviour
{
    public float coolTimer;

    public void Update()
    {
        GetComponent<Animator>().speed = coolTimer;
    }

}
