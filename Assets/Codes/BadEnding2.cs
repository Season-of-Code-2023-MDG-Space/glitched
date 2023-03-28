using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class BadEnding2 : Room
{
    string[] words = {"You get tired of attacking and defending.\n", "With your last remaining strength you hold your ground against 'it'\n", "However, as if mocking your efforts, the entity puts his foot on you, slowly crushing you.\n", "The END"};
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
