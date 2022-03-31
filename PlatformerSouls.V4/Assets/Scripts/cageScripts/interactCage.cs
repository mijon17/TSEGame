using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// opens a dialogue box when interacting with the cage
/// only does this when the cage is empty and the dialogue box is not open
/// </summary>
public class interactCage : interactable, Iinteract
{
    public cageData data;
    public GameObject choiceCanvas;
    public GameObject player;
    public ChoiceBox choiceDialogueRef;

    // Update is called once per frame

    public virtual void interact(){
        Debug.Log("interacting");
        if(data.isEmpty == false && choiceCanvas.activeSelf == false){
            Debug.Log("interacting");
            choiceCanvas.SetActive(true);
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(choiceCanvas.activeSelf == true){
            choiceCanvas.SetActive(false);
        }
    }
}
