using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            controller.canMove = false;
            choiceDialogueRef.makingChoices = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(choiceCanvas.activeSelf == true){
            choiceCanvas.SetActive(false);
        }
    }
}
