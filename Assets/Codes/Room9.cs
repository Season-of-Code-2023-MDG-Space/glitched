using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class Room9 : Room
{
    string[] words = {"The feeling of being followed gets stronger\n", "You want to look back but you are too scared\n"};
    public override async Task<string> enterRoom()
    {
        playSound(MeditationMusic);
        userInput = await displayAndWait(words);
        cs();
        pauseSound(MeditationMusic);
        return "Room10";
    }
}
}
