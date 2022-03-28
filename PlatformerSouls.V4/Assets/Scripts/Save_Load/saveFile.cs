using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class saveFile
{
    public Vector3 playerPos;
    public Quaternion playerRot;
    //player inventory
    public int playerHealth;

    //enemyManager

    //levelManager

    public saveFile(saveFile save){
        playerPos = save.playerPos;
        playerRot = save.playerRot;
        playerHealth = save.playerHealth;
    }

}
