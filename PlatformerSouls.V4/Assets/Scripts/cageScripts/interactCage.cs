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
        Debug.Log("interacting");
        if(!data.isEmpty && choiceCanvas.activeSelf == false){
            choiceCanvas.SetActive(true);
        }
    }
}
