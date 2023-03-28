using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class BadEnding1 : Room
{
    string[] words = {"You stare at the entity.\n", "The entity stares back at you.\n", "It then crushes you.\n", "THE END"};
    public override async Task<string> enterRoom()
    {
        playSound(EndingMusic);
        userInput = await displayAndWait(words);
        cs();
        pauseSound(EndingMusic);
        return "Room1";
    }
}
}
