using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class Room11u : Room
{
    string[] words={"You are greeted by a bright light.\n", "A warm hand comes out to you", "You take it and escape this nightmare"};
    override public async Task<string> enterRoom()
    {
        playSound(MeditationMusic);
        userInput = await displayAndWait(words);
        cs();
        pauseSound(MeditationMusic);
        return "Room1";
    }
}
}