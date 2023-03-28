using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class ExploreSouth : Room
{
    string[] words = {"No sooner did you start walking, than you bumped into a wall", "The walls are covered in something red and sticky", "You decide to stay away."};
    public override async Task<string> enterRoom()
    {
        playSound(MeditationMusic);
        userInput = await displayAndWait(words);
        cs();
        pauseSound(MeditationMusic);
        return "Room8";
    }
}
}
