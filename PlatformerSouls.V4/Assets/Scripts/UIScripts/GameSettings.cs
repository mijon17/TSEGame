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
    public AudioMixer mixer;
    //public Slider volSlider;
    void Start()
    {
        //load preferences from file;
        //potential bugs could arise if PlayerPrefs file does not exist
        //volSlider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f)
    }



}
