using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using TMPro;

namespace Codes{
public class MasterScript : MonoBehaviour
{
    public static Room current_room;
    public static PlayerData pd;
    string temp;
    void Start()
    {
        pd = SaveSystem.LoadData();
        temp = pd.load_room;
        begin();
    }
    async void begin()
    {
        lol:
        switch(temp)
        {
            case "Room1":
            current_room=GetComponent<Room1>();
            break;
            case "Room2":
            current_room=GetComponent<Room2>();
            break;
            case "Room3":
            current_room=GetComponent<Room3>();
            break;
            case "Room4":
            current_room=GetComponent<Room4>();
            break;
            default:
            return;
        }
        temp = await current_room.enterRoom();
        if(temp!=null)
        goto lol;
    }
    void OnApplicationQuit()
    {
        pd.load_room = temp;
        SaveSystem.SaveData(pd);
    }
}
}   