using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace Codes{
public class BossFight : Room
{
    string[] words = {"... : This is it kiddo....", "... : Your little adventure ends here."};
    string[] words2 = {"Entity 707 stands tall infront of you...", "Ready to take your life..."};
    string[] words3 ={"Let the battle begin."};
    string[] words4 = {"Entity 707 : What's your name boy?"};
    string[] words6= {"A- Attack, D- Defend, M- Motivate yourself"};
    string[] words7={"Did I ask?"};
    string[] attackWords={"You attack with all your might.\n", "It dodges quite easily"};
    string[] defendWords={"You defend.\n" ,"Nothing much really happends.\n", "You wonder why you did that"};
    string[] motivations={"You look around and see a dying creature.\nHis pain and suffering motivates you", "You remember a meme you saw on Reddit.\nIt motivates you.", "You remember 2+2 equals 4.\nIt motivates you.", "You try to search for some motivation.\n It motivates you.", "You cannot think of anymore motivation"};
    string[] pswd={"E2Z_V1CT0RY"};
    public override async Task<string> enterRoom()
    {
        playSound(BossMusic);
        userInput = await displayAndWait(words);
        cs();
        userInput = await displayAndWait(words2);
        cs();
        userInput = await displayAndWait(words3);
        int health = MasterScript.pd.BossFightHealth;
        int counter=0;
        int motCounter=0;
        userInput = await displayAndWait(words4);
        if(userInput.ToLower()=="joe")
        {
            string[] words5 = {"Joe who?"};
            userInput = await displayAndWait(words5);
            if(userInput.ToLower()=="joe mama")
            return "EndingLMAO";
        }
        userInput = await displayAndWait(words7);
        gotoMomint:
        userInput = await displayAndWait(words6);
        cs();
        if(userInput.ToLower()=="a")
        {
            userInput = await displayAndWait(attackWords);
            counter++;
        }
        else if(userInput.ToLower()=="d")
        {
            userInput = await displayAndWait(defendWords);
            counter++;
        }
        else if(userInput.ToLower()=="m")
        {
            userInput = await displayAndWait();
            motCounter++;
        }
        else
        {
            return "BadEnding1";
        }
        cs();
        if(counter==5)
        return "BadEnding2";
        if(motCounter==5)
        motCounter--;
        if(health>0)
        goto gotoMomint;
        pauseSound(BossMusic);
        userInput = await displayAndWait(pswd);
        return "GoodEnding1";
    }
}
}
