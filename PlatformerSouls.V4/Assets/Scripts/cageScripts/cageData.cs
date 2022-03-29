using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cageData : MonoBehaviour
{
    public bool isEmpty;

    public int healthBuff;
    public int attackRateBuff;
    public int damageBuff;
    public int manaBuff;
    public int speedBuff;

    //NPC data for use where freed is used.
    public GameObject NPC;
    public Vector3 npcLocation;
    public Quaternion npcRotation;

    public cageData(bool empty, GameObject npc){
        this.isEmpty = empty;
        this.NPC = npc;
    }

}
