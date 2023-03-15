using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading.Tasks;

namespace Codes{
public class UIMethods : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI txt;
     public TMP_InputField inputField;
     public string autoFillText="";
     public bool autoCompleteEnabled=false;
     void Start()
     {
        emptyText();
     }

    public async Task<string> WaitForInput() //waits for input from the user
    {
        var inputTask = new TaskCompletionSource<string>();
        inputField.onEndEdit.AddListener(input =>
        {
            inputTask.SetResult(input);
        });
        string result = await inputTask.Task;

        inputField.onEndEdit.RemoveAllListeners();

        return result;
    }
    void Update() //checks for 'tab' key press
    {
        if(autoCompleteEnabled && Input.GetKeyDown(KeyCode.Tab))
        {
            StopCoroutine(Room.current_cr);
            txt.text = autoFillText;
            autoCompleteEnabled = false;
        }
    }
    public void printxt(string s) //print the text on the TMPro
    {
        txt.text = s;
    }

    public IEnumerator textEffect(params string[] s) //cool text effect B)
    {
        autoCompleteEnabled = true;
        autoFillText = txt.text;
        for(int i=0; i<s.Length; i++)
        {
            autoFillText += s[i];
        }
        var rtn=new WaitForSeconds(0.1f);
        var rtn2=new WaitForSeconds(1);
        for (int i=0; i<s.Length; i++)
        {
            for (int j=0; j<s[i].Length; j++)
            {
                txt.text=txt.text+s[i][j];
                yield return rtn;
            }
            yield return rtn2;
        }
        yield break; 
    }
    public void showInputter()
    {
        inputField.enabled = true;
    }
    public void hideInputter()
    {
        inputField.enabled = false;
    }
    public void emptyText()
    {
        txt.text = null;
    }
    public void flushInput()
    {
        inputField.text = null;
    }
}
}
