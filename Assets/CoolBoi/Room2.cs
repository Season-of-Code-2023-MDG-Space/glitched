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
        var x = StartCoroutine(uim.textEffect("Before we begin, lets get the game familiar with you\n", "Answer these questions as TrutHfu1ly as possilbe\n", "You don't need to type anything, just think of the the answer in your mind\n", "Enter anything to c0ntinUE"));
        uim.showInputter();
        string c = await uim.WaitForInput();
        uim.emptyText();
        uim.flushInput();
        StopCoroutine(x);
        return "Room3";
    }
}
}