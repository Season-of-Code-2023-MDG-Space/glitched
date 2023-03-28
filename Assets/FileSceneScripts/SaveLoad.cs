using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System.IO;

public class SaveLoad : MonoBehaviour
{
    static string path;
    // Start is called before the first frame update
    void Start()
    {
        path = Application.persistentDataPath + "/player.fun";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void SaveData(PlayerData pd)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream, pd);
        stream.Close();
    }
    public static PlayerData LoadData()
    {
        if(File.Exists(path))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data = binaryFormatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
        }
        else
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Create);
            PlayerData temp = new PlayerData();
            temp.load_room = "Room1";
            formatter.Serialize(stream, temp);
            stream.Close();
            return temp;
        }
    }
}
