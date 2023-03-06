using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace CoolBoi{
public class Room1 : Room
{
    public override async Task<string> enterRoom()
    {
        FindObjectOfType<AudioManager>().Play("MeditationMusic");
        uim.hideInputter();
        var x = StartCoroutine(uim.textEffect("Welcome to Room1\n", "A - Room 2\n", "B - Room1\n"));
        uim.showInputter();
        string c = await uim.WaitForInput();
        StopCoroutine(x);
        uim.emptyText();
        uim.flushInput();
        if(c=="A")
        return "Room2";
        else
        return "Room1";
    }
}
}
