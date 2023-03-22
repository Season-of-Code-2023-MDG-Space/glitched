using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MasterScript : MonoBehaviour
{
    public _Folder current_dir;
    public GameObject filePrefab;
    public GameObject folderPrefab;
    static List<GameObject> displayedIcons;
    void Start()
    {
        displayedIcons = new List<GameObject>();
        displayCurrentDirectory();
    }
    void displayCurrentDirectory()
    {
        int j=0;
        foreach (Icon i in current_dir.contentWithin)
        {
            GameObject temp;
            if(i is _Folder)
            {
                temp = Instantiate(folderPrefab);
            }
            else
            {
                temp = Instantiate(filePrefab);
            }
            displayedIcons.Add(temp);
            temp.transform.position = new Vector2(-10+j*2, 3.5f);
            _PrefabData pd = temp.GetComponent<_PrefabData>();
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
}
