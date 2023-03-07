using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace CoolBoi{
public class Room4 : Room
{
    public override async Task<string> enterRoom()
    {
        FindObjectOfType<AudioManager>().Play("MeditationMusic");
        uim.hideInputter();
        var x = StartCoroutine(uim.textEffect("Ending 1 of ??\n", "No :|"));
        uim.showInputter();
        string c = await uim.WaitForInput();
        StopCoroutine(x);
        uim.emptyText();
        uim.flushInput();
        return "Room1";
    }
}
}
