using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class MasterScript : MonoBehaviour
{
    public _Folder[] startFolder;
    public _Folder current_dir;
    public GameObject filePrefab;
    public GameObject folderPrefab;
    public GameObject titlePrefab;
    static List<GameObject> displayedIcons;
    void Start()
    {
        //SceneManager.LoadScene("DirectoryView");
        displayedIcons = new List<GameObject>();
        if(SaveLoad.LoadData().resetPGF == true)
        {
            PlayerPrefs.DeleteAll();
            PlayerData tmp = SaveLoad.LoadData();
            tmp.resetPGF=true;
            SaveLoad.SaveData(tmp);

        }
        string temp = SaveLoad.LoadData().load_room;
        if(temp=="Room3")
        current_dir = startFolder[0];
        else if(temp=="Room8")
        current_dir = startFolder[1];
        else if(temp=="Room10")
        current_dir = startFolder[2];
        else
        Application.Quit();
        displayCurrentDirectory();
    }
    void displayCurrentDirectory()
    {
        GameObject temp;
        temp=Instantiate(folderPrefab);
        displayedIcons.Add(temp);
        temp.transform.position = new Vector2(-10, 3.5f);
        _PrefabData pd = temp.GetComponent<_PrefabData>();
        temp = Instantiate(titlePrefab);
        TextMeshProUGUI tmp = temp.transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
        tmp.text="..";
        temp.transform.position = new Vector2(-10, 2);
        displayedIcons.Add(temp);
        pd.iconToRepresent = current_dir.parent;
        int j=1;
        foreach (Icon i in current_dir.contentWithin)
        {
            if(i is _Folder)
            {
                temp = Instantiate(folderPrefab);
            }
            else
            {
                temp = Instantiate(filePrefab);
            }
            displayedIcons.Add(temp);
            temp.transform.position = new Vector2(-10+j*3f, 3.5f);
            pd = temp.GetComponent<_PrefabData>();
            temp = Instantiate(titlePrefab);
            tmp = temp.transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
            tmp.text = i.title;
            temp.transform.position = new Vector2(-10+j*3f, 2);
            displayedIcons.Add(temp);
            pd.iconToRepresent = i;
            j++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void folderClicked(_Folder f)
    {
        Debug.Log("Hooraay");
        Debug.Log(f.title);
        foreach(GameObject i in displayedIcons)
        {
            Destroy(i);
        }
        current_dir=f;
        displayCurrentDirectory();
    }
    public void fileClicked(_File f)
    {
        SceneManager.LoadScene(f.SceneToSwitchTo);
    }
}
