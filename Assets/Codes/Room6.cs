using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class Room6 : Room
{
    string[] words = {"You wake up in a dark room.\n", "You feel a strange presence around you.\n", "Something is not right."};
    public override async Task<string> enterRoom()
    {
        playSound(MeditationMusic);
        userInput = await displayAndWait(words);
        cs();
        pauseSound(MeditationMusic);
        return "Room7";
    }
}
}
