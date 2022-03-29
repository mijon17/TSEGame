using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionMechanic : MonoBehaviour
{

    //interactable class that when enter trigger
    //causes player interaction system to check for the object using overlap box
    //interaction system will store this value as well
    //with the returning output, the player interaction system can check in an update func if they have pressed interact button
    //when they do, use interact function

    private PlayerController player;
    private Vector2 boxCentre;
    private Vector2 boxSize;
    private float boxAngle;
    public interactable toInteract;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.canInteract && Input.GetKeyDown(KeyCode.F))//might need rearranging;
        {
            if (toInteract != null)
            {
                if(toInteract.gameObject.GetComponent<Iinteract>() != null){
                    toInteract.gameObject.GetComponent<Iinteract>().interact();
                }
            }
        }
    }



}
