using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;
using System.Threading;
using TMPro;

namespace CoolBoi{
public class Room : MonoBehaviour
{
    public TextMeshProUGUI txt = MasterScript.tx;
    public virtual Task<Room> enterRoom()
    {
        Debug.Log("Error");
        return null;
    }
    public void printxt(string s)
    {
        txt.text = s;
    }
    public IEnumerator textEffect(string s)
    {
        string x="";
        var rtn=new WaitForSeconds(0.15f);
        for (int i=0; i<s.Length; i++)
        {
            x=x+s[i];
            txt.text=x;
            yield return rtn;
        }
        yield break;
    }
    public async Task<string> Room1()
    {
        Debug.Log("Welcome to Room1");
        var x = StartCoroutine(textEffect("Welcome to Room1\nSelect \nA- Room2\nB- Room1"));
        Debug.Log("Waiting for input");
        string c = await InputExample.WaitForInput();
        StopCoroutine(x);
        if(c=="A")
        return "Room2";
        else
        return "Room1";
    }
}
}