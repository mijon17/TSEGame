using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialLevelManager : MonoBehaviour
{
    [SerializeField]
    private enemyManager[] enemyTable;
    void Start()
    {
        //check if save file contains level details and load them if so

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnEnemies(){
        if (enemyTable != null)
        {
            for (int i = 0; i < enemyTable.Length; i++)
            {
                if (enemyTable[i].alive)
                {
                    Instantiate(enemyTable[i].enemyType, enemyTable[i].spawnPos, enemyTable[i].spawnRot);
                }
            }
        }
    }
}
