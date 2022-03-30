using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Free_Slay : MonoBehaviour
{
    public cageData cageData;
    public GameObject player;
    public PlayerHealth health;
    public PlayerCombat playerCom;
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        //check whether isEmpty, if it is, then enable particle effect and prevent interacting
    }

    public void free(){
        cageData.isEmpty = true;

        //trigger particle effect
        //save
        //instantiate NPC
    }

    public void slay(){
        cageData.isEmpty = true;
        player.AddComponent<drainBuff>();
        //trigger particle effect
        //save
        
    }

}
