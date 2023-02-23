using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Room1 : Room
{
    public override Room enterRoom()
    {
        Debug.Log("Welcome to Room1");
        MasterScript.tx.text="Welcome to Room1";
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
