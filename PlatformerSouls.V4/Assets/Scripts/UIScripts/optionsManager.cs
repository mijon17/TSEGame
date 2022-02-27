using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class optionsManager : MonoBehaviour
{
    private List<GameObject> mainMenuElements = new List<GameObject>();
    public UIManager mainMenuManager;
    public GameObject optionsPanel;
    public AudioMixer mixer;
    public float volume;
    //may need reference to slider value to ensure th
    //private int brightness
    // Start is called before the first frame update
    void Start()
    {
        mainMenuElements = mainMenuManager.mainMenuElements;
        //
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void back(){
        optionsPanel.SetActive(false);
        foreach(GameObject obj in mainMenuElements){
            obj.SetActive(true);
        }
    }
    public void apply(){
        //save system preferences
        SetVolume(volume);//set to slider value
    }
    public void SetVolume(float sliderValue)
    {
        Debug.Log(sliderValue);
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }
}
