using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Room2 : Room
{
    override public Room enterRoom()
    {
        Debug.Log("Welcome to Room2");
        MasterScript.tx.text="You are sleeping on your bed.\nA- Wake Up\nB- Keep Sleeping";
        Repeater:
        Debug.Log("Waiting for input");
        Thread.Sleep(20);
        if(MasterScript.input!="A"||MasterScript.input!="B")
        goto Repeater;
        string c=MasterScript.input;
        MasterScript.input="";
        if(c=="A")
        return new Room2();
        else
        return new Room1();
    }
}
