using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes
{
    public class Room3 : Room
    {
        string[] words1 = { "Type anything when you are done thinking about the answer\n", "What is the meaning of life?\n" };
        string[] words2 = { "Do you believe in entities?\n" };
        string[] words3 = { "Do yoU BELIEVE IN ENTITIES?" };
        public override async Task<string> enterRoom()
        {
            playSound(MeditationMusic);
            if (!SaveSystem.LoadData().allowRoom3)
            {
                userInput = await displayAndWait(words1);
                //addText(words1);
                ci();
                userInput = await displayAndWait(words2);
                //addText(words2);
                cs();
                stopSound(MeditationMusic);
                playSound(Glitch);
                userInput = await displayAndWait(words3);
                //addText(words3);
                stopSound(Glitch);
                cs();
                return Room1;
            }
            else
            {
                Debug.Log("It worrkkkkeeedddddd!!!!!!!");
                return "Room6";
            }
        }
    }
}
