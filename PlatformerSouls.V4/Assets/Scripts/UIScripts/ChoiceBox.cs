using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceBox : dialogueBoxScript
{
    public Text choice1;
    public Text choice2;
    public GameObject pointer;
    public int index = 0;

    public Vector3 choice1Location;
    public Vector3 choice2Location;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (index == 0)
            {
                //choice 0 function
            }
            else if (index == 1)
            {
                //choice 1 function
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow) && index == 0){
            index = 1;
            //change pointer location
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow) && index == 1){
            index = 0;
            //change pointer location
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) && index == 0){
            index = 1;
            //change pointer location
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) && index == 1){
            index = 0;
            //change pointer location
        }
    }
}
