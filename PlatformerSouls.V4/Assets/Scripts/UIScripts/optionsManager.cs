using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsManager : MonoBehaviour
{
    private List<GameObject> mainMenuElements = new List<GameObject>();
    public UIManager mainMenuManager;
    public GameObject optionsPanel;
    //private float volume;
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
        //PlayerPrefs.SetFloat("volume", volume);
    }
}
