using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class Room10 : Room
{
    string[] words = {"You come across 3 doors\n", "A - Room 66\n", "B - Room 38\n", "C - Room 50"};
    public override async Task<string> enterRoom()
    {
        playSound(MeditationMusic);
        userInput = await displayAndWait(words);
        cs();
        pauseSound(MeditationMusic);
        if(userInput.ToLower()=="a"&&SaveSystem.LoadData().allowRoom10)
        return "Room11u";
        else if(userInput.ToLower()=="a") 
        return "Room11l";
        else if(userInput.ToLower()=="b")
        return "Ending2";
        else if(userInput.ToLower()=="c")
        return "Fight";
        else
        return "Room10";
    }
}
}
