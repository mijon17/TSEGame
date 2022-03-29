using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChoiceBox : MonoBehaviour
{

    public GameObject pointer;
    public Free_Slay choices;
    public int index = 0;


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
        if (Input.GetKeyDown(KeyCode.LeftArrow) && index == 0)
        {
            index = 1;
            //change pointer location
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && index == 1)
        {
            index = 0;
            //change pointer location
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && index == 0)
        {
            index = 1;
            //change pointer location
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && index == 1)
        {
            index = 0;
            //change pointer location
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
