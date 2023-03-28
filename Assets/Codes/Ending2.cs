using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class Ending2 : Room
{
    string[] words={"As soon as you open the door, you feel a push from behind.\n", "You fall down a cliff. About a minute later a loud \"SPLAT\" sound.\n", "Also, did you know?\n", "D+E+A+T+H = 38"};
    override public async Task<string> enterRoom()
    {
        playSound(EndingMusic);
        userInput = await displayAndWait(words);
        cs();
        pauseSound(EndingMusic);
        return "Room1";
    }
}
}