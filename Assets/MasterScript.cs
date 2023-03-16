using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MasterScript : MonoBehaviour
{
    public _Folder current_dir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*void CallBack(_Folder a, int x)
    {
        foreach (Icon i in a.contentWithin)
        {
            string s="";
            for (int j = 0; j<x; j++)
            s+=" ";
            s+=i.title;
            Debug.Log(s);
            if (i is _Folder)
            CallBack((_Folder)i, x+1);
        }
    }
    */
}
