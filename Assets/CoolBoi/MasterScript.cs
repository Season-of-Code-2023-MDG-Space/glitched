using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

namespace CoolBoi{
public class MasterScript : MonoBehaviour
{
    public static GameObject g; //for storing 'DisplayText' Game object. kept static as it will remain unique throughout playtime.
    public static Text tx; //for containing text part. static for same reason.
    public static GameObject g2; //for storing 'Inputter' Game object.
    Room obj;
    void Start()
    {
        g=GameObject.Find("Canvas/DisplayText");
        tx = g.GetComponent<Text>();
        obj = new Room1();
        g2=GameObject.Find("Canvas/Inputter");
        InputExample.inputField = g2.GetComponent<InputField>();
        Starter();
    }
    async void Starter()
    {
        while(obj!=null)
        obj=await obj.enterRoom();
        tx.text="Game Over";
        Debug.Log("Stopped");
    }
}
}   