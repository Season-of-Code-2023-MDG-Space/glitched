using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class Room2 : Room
{
    string[] words={"Before we begin, lets get the game familiar with you\n", "Answer these questions as TrutHfu1ly as possilbe\n", "You don't need to type anything, just think of the the answer in your mind\n", "Enter anything to c0ntinUE"};
    override public async Task<string> enterRoom()
    {
        playSound(MeditationMusic);
        userInput = await displayAndWait(words);
        cs();
        pauseSound(MeditationMusic);
        return Room3;
    }
}
}