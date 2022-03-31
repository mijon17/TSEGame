using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// script for using the choice box when interacting with the cage
/// too free human or slay them.
/// </summary>
public class ChoiceBox : MonoBehaviour
{

    public GameObject pointer;
    public Free_Slay choices;
    public int index = 0;

    //locations for pointer to indicate which choice is highlighted
    public Vector3 choice1Location;
    public Vector3 choice2Location;

    void Start()
    {
        //pointer at choice location 1
        pointer.transform.localPosition = choice1Location;
    }

    // Update is called once per frame
    void Update()
    {
        //use the e key to make choice
        //choice cannot be made when the box is inactive, so bool check may not be neccessary.
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
        //script for using the arrow keys to navigate choices
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

    public void choice0Func()
    {
        choices.free();
    }

    public void choice1Func()
    {
        choices.slay();
    }
}
