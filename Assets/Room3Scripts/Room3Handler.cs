using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Room3Handler : MonoBehaviour
{
    public string defaultText;
    public string requiredText;
    TMP_InputField inpf1;
    public Button b;
    void Awake()
    {
        inpf1 = gameObject.GetComponent<TMP_InputField>();
        inpf1.onEndEdit.AddListener(TextEnter);
        if(!PlayerPrefs.HasKey("Entered"))
        {
            PlayerPrefs.SetString("Entered", "false");
        }
        inpf1.text=PlayerPrefs.GetString("Entered");
        b.onClick.AddListener(buttonClicked);
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
        PlayerPrefs.SetString("Entered", inpf1.text);
        if(inpf1.text==requiredText)
        {
            PlayerData temp =SaveLoad.LoadData();
            temp.allowRoom3 = true;
            SaveLoad.SaveData(temp);
        }
        SceneManager.LoadScene("DirectoryView");
    }
}
