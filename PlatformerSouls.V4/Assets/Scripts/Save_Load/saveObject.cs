using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public static class saveObject
{
   //creates save file by serialising data into said file
    //https://weeklyhow.com/how-to-save-load-game-in-unity/
    public static void save(saveFile save){
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerSave.sve";
        FileStream stream = new FileStream(path, FileMode.Create);
        saveFile saveData = new saveFile(save);
        formatter.Serialize(stream, saveData);
        stream.Close();

    }

    public static saveFile load(){
        string path = Application.persistentDataPath + "/playerSave.sve";

        if(File.Exists(path)){
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            saveFile saveData = formatter.Deserialize(stream) as saveFile;
            stream.Close();
            return saveData;
        }
        else{
            Debug.LogError("Error: save file not found ");

        }
        return null;
    }
}
