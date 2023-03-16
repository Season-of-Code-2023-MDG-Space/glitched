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
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data = binaryFormatter.Deserialize(stream) as PlayerData;
            return data;
        }
        else
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Create);
            PlayerData temp = new PlayerData();
            temp.load_room = "Room1";
            formatter.Serialize(stream, temp);
            return temp;
        }
    }
}
}
