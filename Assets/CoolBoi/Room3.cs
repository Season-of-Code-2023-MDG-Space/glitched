using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace CoolBoi{
public class Room3 : Room
{
    public override async Task<string> enterRoom()
    {
        uim.hideInputter();
        var x = StartCoroutine(uim.textEffect("Type anything when you are done thinking about the answer\n", "What is the meaning of life?\n"));
        uim.showInputter();
        string c = await uim.WaitForInput();
        StopCoroutine(x);
        uim.flushInput();
        x = StartCoroutine(uim.textEffect("Do you believe in entities?"));
        uim.showInputter();
        c = await uim.WaitForInput();
        StopCoroutine(x);
        uim.flushInput();
        FindObjectOfType<AudioManager>().Stop("MeditationMusic");
        FindObjectOfType<AudioManager>().Play("Glitch");
        x = StartCoroutine(uim.textEffect("Do yoU BELIEVE IN ENTITIES?"));
        uim.showInputter();
        c = await uim.WaitForInput();
        StopCoroutine(x);
        uim.emptyText();
        uim.flushInput();
        return "Room1";
    }
}
}
