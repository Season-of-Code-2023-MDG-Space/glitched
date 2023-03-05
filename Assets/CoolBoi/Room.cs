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
    public static UIMethods uim;
    void Start()
    {
        GameObject g = GameObject.Find("GameController");
        uim = g.GetComponent<UIMethods>();
    }
    public virtual Task<string> enterRoom()
    {
        Debug.Log("Error");
        return null;
    }
}
}