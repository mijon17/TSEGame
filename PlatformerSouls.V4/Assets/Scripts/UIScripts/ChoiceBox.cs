using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChoiceBox : MonoBehaviour
{

    public GameObject pointer;
    public PlayerController playerController;
    public Free_Slay choices;
    public bool makingChoices;
    public int index = 0;


    public Vector3 choice1Location;
    public Vector3 choice2Location;

    void Start()
    {
        //pointer at choice location 1
        makingChoices = true;
        pointer.transform.localPosition = choice1Location;
    }

    // Update is called once per frame
    void Update()
    {
        if(makingChoices){
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (index == 0)
                {
                    choice0Func();
                }
                else if (index == 1)
                {
                    choice1Func();
                }
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) && index == 0)
            {
                index = 1;
                pointer.transform.localPosition = choice2Location;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && index == 1)
            {
                index = 0;
                pointer.transform.localPosition = choice1Location;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && index == 0)
            {
                index = 1;
                pointer.transform.localPosition = choice2Location;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && index == 1)
            {
                index = 0;
                pointer.transform.localPosition = choice1Location;
            }
        }
    }

    public void choice0Func()
    {
        playerController.canMove = true;
        choices.free();
    }

    public void choice1Func()
    {
        playerController.canMove = true;
        choices.slay();
    }
}
