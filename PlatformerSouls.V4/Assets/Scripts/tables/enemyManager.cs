using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    private static int newId = 0;
    public int ID;
    public GameObject enemyType;
    public Vector3 spawnPos;
    public Quaternion spawnRot;
    public bool alive;

     
    void Start()
    {
        ID = newId;
        newId++;
    }

}
