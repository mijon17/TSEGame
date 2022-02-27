using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsConnection : MonoBehaviour
{
    public GameSettings _settings;
    [SerializeField]
    public static GameSettings s;
    public static settingsConnection instance;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if(settingsConnection.instance == null){
            settingsConnection.instance = this;

        }
        if(settingsConnection.s == null){
            settingsConnection.s = _settings;
        }
    }
}
