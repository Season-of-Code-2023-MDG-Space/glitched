using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DoubleClickChecker : MonoBehaviour
{
    public float firstLeftClickTime;
    public float timeBetweenLeftClick = 0.5f;
    public bool isTimeCheckAllowed = true;
    public int leftClickCount = 0;

    public bool isMouseOver = false;
    public GameObject g;

    void Start()
    {
        g=GameObject.Find("GameController");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isMouseOver)
        {
            leftClickCount += 1;
        }

        if (leftClickCount == 1 && isTimeCheckAllowed)
        {
            firstLeftClickTime = Time.time;
            StartCoroutine(DetectDoubleLeftClick());
        }
    }

    void OnMouseOver()
    {
        isMouseOver = true;
    }

    void OnMouseExit()
    {
        isMouseOver = false;
    }

    public IEnumerator DetectDoubleLeftClick()
    {
        isTimeCheckAllowed = false;
        while (Time.time < firstLeftClickTime + timeBetweenLeftClick)
        {
            if (leftClickCount == 2)
            {
                Debug.Log("Double Click");
                if(gameObject.CompareTag("_Folder"))
                {
                    g.SendMessage("folderClicked", (_Folder)(gameObject.GetComponent<_PrefabData>().iconToRepresent));
                }
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        leftClickCount = 0;
        isTimeCheckAllowed = true;
        yield break;
    }   
}
