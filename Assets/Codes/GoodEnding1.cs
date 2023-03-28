using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class GoodEnding1 : Room
{
    string[] words = {"Ending\n","The fight 'unexpectedly' ends and the entity collapses.\n", "You decide to look for an exit.\n", "Hopefully you will find one."};
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
