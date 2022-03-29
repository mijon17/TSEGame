/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talk : MonoBehaviour, Iinteract
{

    public dialogueBoxScript[] dialogueList;
    public int dialogueBoxIndex;
    public int Text dialogueText;

    public GameObject dialogueBoxCanvas;
    public GameObject dialogueBoxObject;
    public GameObject choiceBoxObject;
    private int dialogueLength;

    public bool makingChoice;
    // Start is called before the first frame update
    void Start()
    {
        dialogueBoxIndex = 0;
        dialogueLength = dialogueList.Length;
        choiceBoxObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void interact(){
        //pause game?
        if(!makingChoice){
            choiceBoxObject.SetActive(false);
            dialogueText = dialogueList[dialogueBoxIndex].dialogue;

            if (dialogueBoxIndex != dialogueLength - 1)
            {
                if (dialogueList[dialogueBoxIndex].GetType() == typeof(ChoiceBox))
                {
                    dialogueBoxObject.SetActive(false);
                    choiceBoxObject.SetActive(true);
                    makingChoice = true;
                }

                dialogueBoxIndex++;
                dialogueText = dialogueList[dialogueBoxIndex].dialogue;
            }
        }

    }
}
*/