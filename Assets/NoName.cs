using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class NoName : MonoBehaviour
{
    public float firstLeftClickTime;
    public float timeBetweenLeftClick = 0.5f;
    public bool isTimeCheckAllowed = true;
    public int leftClickCount = 0;

    void Update()
    {
        if(Input.GetMouseButtonUp(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            leftClickCount += 1;
        }
        if(leftClickCount == 1 && isTimeCheckAllowed)
        {
            firstLeftClickTime = Time.time;
            StartCoroutine(DetectDoubleLeftClick());
        }
    }
    public IEnumerator DetectDoubleLeftClick()
    {
        isTimeCheckAllowed = false;
        while(Time.time < firstLeftClickTime + timeBetweenLeftClick)
        {
            if(leftClickCount == 2)
            {
                Debug.Log("Double Click Lol");
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        leftClickCount = 0;
        isTimeCheckAllowed = true;
    }
}
