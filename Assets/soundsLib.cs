using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundsLib : MonoBehaviour
{
    public AudioSource[] lib;

    public void audioPlay(string sound)
    {
        switch (sound)
        {
            case ("Walk"):
                lib[0].Play();
                break;
            case ("MenuOpen"):
                lib[1].Play();
                break;
            case ("CraftItem"):
                lib[2].Play();
                break;
            case ("OnClick"):
                lib[3].Play();
                break;
        }
    }

    public void PlayAudio()
    {
        lib[3].Play();
    }
}
