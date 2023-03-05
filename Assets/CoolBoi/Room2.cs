using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace CoolBoi{
public class Room2 : Room
{
    override public async Task<string> enterRoom()
    {
        uim.hideInputter();
        var x = StartCoroutine(uim.textEffect("Welcome to Room2\n", "A- Exit\n", "B- Room1"));
        uim.showInputter();
        string c = await uim.WaitForInput();
        uim.emptyText();
        uim.flushInput();
        StopCoroutine(x);
        if(c=="A")
        return null;
        else
        return "Room1";
    }
}
}