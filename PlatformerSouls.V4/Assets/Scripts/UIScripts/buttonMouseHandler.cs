using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMouseHandler : MonoBehaviour
{
    //attaches to every button
    //using public position, dot knows where to go
    public UIManager manager;
    public Vector3 dotPosition;
    public GameObject pointer;
    public int buttonIndex;
    void Start()
    {
        if(manager){
            
        }
    }

    //changes UIManager index and pointer position to highlighted button
    private void OnMouseOver()
    {
        manager.index = buttonIndex;
        pointer.transform.position = dotPosition;
    }
}
