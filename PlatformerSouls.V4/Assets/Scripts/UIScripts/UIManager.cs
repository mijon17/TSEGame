using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

//this is predominanently for using keys to interact
public class UIManager : MonoBehaviour//also make script for using buttons to click using mouse as well as keys
{
    public List<GameObject> buttonElements = new List<GameObject>();//use list to 
    private int index;//used to index button elements to see which button is being selected

    public GameObject background;

    //use positions to place pointer at their locations in canvas space
    public Vector3 newGamePos;
    public Vector3 loadGamePos;
    public Vector3 optionsPos;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //if input enter
    }
    public void newGame(){

    }

    public void LoadGame(){

    }

    public void openOptions(){

    }

    public void incrementIndex(){

    }
    public void decrementIndex(){

    }
}
