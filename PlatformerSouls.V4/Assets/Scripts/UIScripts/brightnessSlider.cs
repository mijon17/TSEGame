using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brightnessSlider : MonoBehaviour
{
    public void setBrightness(float sliderValue){
        Screen.brightness = sliderValue;
    }
}
