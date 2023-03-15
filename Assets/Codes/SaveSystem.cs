using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Codes{

public static class SaveSystem
{
    static string path = Application.persistentDataPath + "/player.fun";
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
            Debug.Log("Hello");
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            Debug.Log("2");
            PlayerData data = binaryFormatter.Deserialize(stream) as PlayerData;
            Debug.Log("3");
            return data;
        }
        else
        {
            Debug.Log("0");
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Create);
            PlayerData temp = new PlayerData();
            temp.load_room = "Room1";
            Debug.Log("1");
            formatter.Serialize(stream, temp);
            Debug.Log("2");
            return temp;
        }
    }
}
}
