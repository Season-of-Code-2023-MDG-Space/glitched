using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class Room4 : Room
{
    string[] words = {"Ending 1 of ??\n", "No :|\n", "What did you expect?\n", "Let's try this again, shall we?\n"};
    public override async Task<string> enterRoom()
    {
        playSound(RickRoll);
        userInput = await displayAndWait(words);
        cs();
        return Room1;
    }
}
}
