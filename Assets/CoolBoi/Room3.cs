using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace CoolBoi{
public class Room3 : Room
{
    string[] words1 = {"Type anything when you are done thinking about the answer\n", "What is the meaning of life?\n"};
    string[] words2 = {"Do you believe in entities?"};
    string[] words3= {"Do yoU BELIEVE IN ENTITIES?"};
    public override async Task<string> enterRoom()
    {
        userInput = await displayAndWait(words1);
        ci();
        userInput = await displayAndWait(words2);
        ci();
        stopSound(MeditationMusic);
        playSound(Glitch);
        userInput = await displayAndWait(words3);
        stopSound(Glitch);
        cs();
        return Room1;
    }
}
}
