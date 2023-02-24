using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace CoolBoi{
public class Room
{
    public Text txt = MasterScript.tx;
    public virtual Task<Room> enterRoom()
    {
        Debug.Log("Error");
        return null;
    }
    public void printxt(string s)
    {
        txt.text = s;
    }

}
}