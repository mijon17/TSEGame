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

            }
            else if (index == 1)
            {

            }
        }
    }
}
