using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSingCosing : MonoBehaviour
{
    Vector2 wave;
    public float amp, frq;
    Vector2 orgscale;
    void Start()
    {
        orgscale = transform.localScale;
    }

    void Update()
    {
        float xWave = Mathf.Cos(Time.time * frq) * amp;
        float yWave = Mathf.Sin(Time.time * frq) * amp;

        transform.localScale = orgscale + new Vector2(xWave, yWave);
    }
}
