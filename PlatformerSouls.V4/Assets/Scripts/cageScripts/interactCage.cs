using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactCage : interactable, Iinteract
{
    public cageData data;
    public GameObject choiceCanvas;


    // Update is called once per frame

    public virtual void interact(){
        Debug.Log("interacting");
        if(data.isEmpty == false && choiceCanvas.activeSelf == false){
            Debug.Log("interacting");
            choiceCanvas.SetActive(true);
        }
    }
}
