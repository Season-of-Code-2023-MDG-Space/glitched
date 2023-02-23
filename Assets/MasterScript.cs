using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System;

public class MasterScript : MonoBehaviour
{
    public static GameObject g; //for storing 'DisplayText' Game object. kept static as it will remain unique throughout playtime.
    public static Text tx; //for containing text part. static for same reason.
    Room obj;
    public static string input; //for storing input. static for same reason.
    void Start()
    {
        g=GameObject.Find("Canvas/DisplayText");
        tx = g.GetComponent<Text>();
        obj = new Room1();
        input="";
        Thread t = new Thread(()=>Starter()); //separated room navigation thread to keep the UI active at all times
        t.Start();
    }
    void Starter()
    {
        while(obj!=null)
        obj=obj.enterRoom();
        Debug.Log("Stopped");
    }
    public static void readInput(string s)
    {
        input=s;
        Debug.Log(input);
    }
}