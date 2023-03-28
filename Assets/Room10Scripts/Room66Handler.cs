using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Room66Handler : MonoBehaviour
{
    public string defaultText;
    public string requiredText;
    TMP_InputField inpf1;
    public Button b;
    void Awake()
    {
        inpf1 = gameObject.GetComponent<TMP_InputField>();
        inpf1.onEndEdit.AddListener(TextEnter);
        b.onClick.AddListener(buttonClicked);
        if(!PlayerPrefs.HasKey("EnteredRoom66"))
        {
            PlayerPrefs.SetString("EnteredRoom66", "");
        }
        inpf1.text=PlayerPrefs.GetString("EnteredRoom66");
        if(inpf1.text==requiredText)
        inpf1.readOnly = true;
    }
    void TextEnter(string s)
    {
        if(s==requiredText)
        inpf1.readOnly = true;
        else
        inpf1.text = defaultText;
    }
    void buttonClicked()
    {
        PlayerPrefs.SetString("EnteredRoom66", inpf1.text);
        if(inpf1.text==requiredText)
        {
            PlayerData temp =SaveLoad.LoadData();
            temp.allowRoom10 = true;
            SaveLoad.SaveData(temp);
        }
        SceneManager.LoadScene("DirectoryView");
    }
}
