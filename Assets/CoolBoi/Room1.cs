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
        var x = StartCoroutine(uim.textEffect("Hello!", "\nAnd welcome", "\nShall we begin?", "\ny/n"));
        uim.showInputter();
        string c = await uim.WaitForInput();
        StopCoroutine(x);
        uim.emptyText();
        uim.flushInput();
        if(c=="y")
        return "Room2";
        else
        return "Room4";
    }
}
}
