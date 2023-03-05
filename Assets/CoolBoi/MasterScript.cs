using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using TMPro;

namespace CoolBoi{
public class MasterScript : MonoBehaviour
{
    public static Room current_room;
    void Start()
    {
        current_room=GetComponent<Room1>();
        begin();
    }
    async void begin()
    {
        lol:
        string x = await current_room.enterRoom();
        switch(x)
        {
            case "Room1":
            current_room=GetComponent<Room1>();
            break;
            case "Room2":
            current_room=GetComponent<Room2>();
            break;
            default:
            return;
        }
        goto lol;
    }
}
}   