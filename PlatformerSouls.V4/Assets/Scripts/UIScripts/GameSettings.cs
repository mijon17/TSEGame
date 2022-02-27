using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

[CreateAssetMenu(fileName = "GameSettings", menuName = "GameSettings", order = 1)]
[Serializable]
public class GameSettings : ScriptableObject
{
    private float volume;
    private int brightness;
    void Start()
    {
        //load preferences from file;
    }


}
