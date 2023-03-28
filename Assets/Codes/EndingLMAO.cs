using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class EndingLMAO : Room
{
    string[] words = {"LMAAAOOOO!\n", "Nice work!!"};
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
