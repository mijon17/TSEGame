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
    public Image pointer;

    //use positions to place pointer at their locations in canvas space
    public Vector3 newGamePos = new Vector3(-60, -100, 0);
    public Vector3 loadGamePos = new Vector3(-60, -140, 0);
    public Vector3 optionsPos = new Vector3(-60, 180, 0);

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //if input enter
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            if(index == 0){
                newGame();
            }
            else if(index == 1){
                LoadGame();
            }
            else if(index == 2){
                openOptions();
            }
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            incrementIndex();
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            decrementIndex();
        }
    }
    public void newGame(){
        Debug.Log("Starting new game");
    }

    public void LoadGame(){
        Debug.Log("loading game");
    }

    public void openOptions(){
        Debug.Log("opening options");
    }

    public void incrementIndex(){
        if(index == 2){
            index = 0;
            pointer.transform.position = newGamePos;
        }
        else if(index == 1){
            index++;
            pointer.transform.position = optionsPos;
        }
        else{
            index++;
            pointer.transform.position = loadGamePos;
        }
    }
    public void decrementIndex(){
        if(index == 0){
            index = 2;
            pointer.transform.position = optionsPos;
        }
        else if(index == 1){
            index--;
            pointer.transform.position = newGamePos;
        }
        else{
            index--;
            pointer.transform.position = loadGamePos;
        }
    }
}
