using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class Room8 : Room
{
    string[] words = {"You decide to explore around.\n", "A- Explore East\n", "B- Explore South\n", "C- Explore West"};
    public override async Task<string> enterRoom()
    {
        playSound(MeditationMusic);
        userInput = await displayAndWait(words);
        cs();
        pauseSound(MeditationMusic);
        if(userInput.ToLower()=="a"||userInput.ToLower()=="b"||userInput.ToLower()=="c")
        return "ExploreSouth";
        else if(userInput.ToLower()=="north")
        return "Room9";
        return "Room8";
    }
}
}
