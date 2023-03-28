using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MS : MonoBehaviour
{
    public TMP_InputField f1;
    public TMP_InputField f2;
    public TMP_InputField f3;
    void Start()
    {
        f1.text= "200"; 
        f2.text= "300";
        f3.text= "50";
        f1.onEndEdit.AddListener(Change);
        Debug.Log(Application.persistentDataPath);
        PlayerData pd=SaveLoad.LoadData();
        Debug.Log(pd.load_room);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Change(string s)
    {
        Debug.Log(s);
    }
}
