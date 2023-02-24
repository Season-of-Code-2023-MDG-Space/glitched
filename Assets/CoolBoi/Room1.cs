using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace CoolBoi{
public class Room1 : Room
{
    public override async Task<Room> enterRoom()
    {
        Debug.Log("Welcome to Room1");
        printxt("Welcome to Room1\nSelect \nA- Room2\nB- Room1");
        Debug.Log("Waiting for input");
        string c = await InputExample.WaitForInput();
        if(c=="A")
        return new Room2();
        else
        return new Room1();
    }
}
}
