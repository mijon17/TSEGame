/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceBox : dialogueBoxScript
{
    public Text choice1;
    public Text choice2;
    public GameObject pointer;
    public int index = 0;
    public talk talkScript;

    public Vector3 choice1Location;
    public Vector3 choice2Location;

    void Start()
    {
        //pointer at choice location 1
    }

    // Update is called once per frame
    void Update()
    {
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
        if (Input.GetKeyDown(KeyCode.LeftArrow) && index == 0) {
            index = 1;
            //change pointer location
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && index == 1) {
            index = 0;
            //change pointer location
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && index == 0) {
            index = 1;
            //change pointer location
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && index == 1) {
            index = 0;
            //change pointer location
        }
    }

    public void choice0Func() {
        talkScript.makingChoice = false;
    }

    public void choice1Func(){
        talkScript.makingChoice = false;
    }
}
*/