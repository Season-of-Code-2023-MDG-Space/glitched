using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;
using System.Threading;
using TMPro;

namespace Codes{
public class Room : MonoBehaviour
{
    protected string userInput;
    public static Coroutine current_cr;
    public static UIMethods uim;
    protected string MeditationMusic = "MeditationMusic"; //protected used to hide from inspector. [HideFromInspector] can also be used but would not prefer it.
    protected string Glitch = "Glitch";
    protected string Room1 = "Room1";
    protected string Room2 = "Room2";
    protected string Room3 = "Room3";
    protected string Room4 = "Room4";
    protected string RickRoll = "RickRoll";
    protected string EndingMusic = "EndingMusic";
    protected string BossMusic = "BossMusic";
    void Start()
    {
        GameObject g = GameObject.Find("GameController");
        uim = g.GetComponent<UIMethods>();
    }
    public virtual Task<string> enterRoom() //Tasks to be performed on entering a given room
    {
        Debug.Log("Error");
        return null;
    }
    public void playSound(string s)
    {
        FindObjectOfType<AudioManager>().Play(s);
    }
    public void stopSound(string s)
    {
        FindObjectOfType<AudioManager>().Stop(s);
    }
    public void pauseSound(string s)
    {
        FindObjectOfType<AudioManager>().Pause(s);
    }
    public async Task<string> displayAndWait(params string[] words)
    {
        string x= uim.txt.text + addText(words);
        current_cr = StartCoroutine(uim.textEffect(words));
        string c = await uim.WaitForInput();
        uim.txt.text = x;
        try{
        StopCoroutine(current_cr);
        }
        finally{}
        return c;
    }
    public void display(float t, params string[] words)
    {
        string x= uim.txt.text + addText(words);
        current_cr = StartCoroutine(uim.textEffect(words));
        uim.txt.text = x;  
    }
    public void cs() //clear screen (clears input too)
    {
        uim.emptyText();
        ci();
    }
    public void ci() //clear input
    {
        uim.flushInput();
    }
    public string addText(params string[] s)
    {
        string temp="";
        foreach (string str in s) {
        temp += str;
        }
        return temp;
    }
}
}