using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class Room1 : Room
{
    string[] words = {"Hello!", "\nAnd welcome", "\nShall we begin?", "\ny/n"};
    public override async Task<string> enterRoom()
    {
        playSound(MeditationMusic);
        userInput = await displayAndWait(words);
        cs();
        pauseSound(MeditationMusic);
        if(userInput=="y"||userInput=="Y")
        return Room2;
        else if(userInput=="n"||userInput=="N")
        return Room4;
        else
        return Room1;
    }
}
}
