using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace CoolBoi{
public class Room2 : Room
{
    override public async Task<Room> enterRoom()
    {
        Debug.Log("Welcome to Room2");
        printxt("Welcome to Room2\nSelect\nA- Exit\nB- Room1");
        Debug.Log("Waiting for input");
        string c = await InputExample.WaitForInput();
        if(c=="A")
        return null;
        else
        return new Room1();
    }
}
}