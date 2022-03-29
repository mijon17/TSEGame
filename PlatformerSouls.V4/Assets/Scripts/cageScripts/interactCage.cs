using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactCage : MonoBehaviour, Iinteract
{
    public cageData data;
    public GameObject choiceCanvas;
    void Start()
    {
        
    }

    // Update is called once per frame

    public void interact(){
        if(data.isEmpty == false && choiceCanvas.activeSelf == false){
            Debug.Log("interacting");
            choiceCanvas.SetActive(true);
        }
    }
}
