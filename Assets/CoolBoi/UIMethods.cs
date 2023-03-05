using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading.Tasks;

namespace CoolBoi{
public class UIMethods : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI txt;
     public TMP_InputField inputField;
     void Start()
     {
        emptyText();
     }

    public async Task<string> WaitForInput()
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
    public void printxt(string s)
    {
        txt.text = s;
    }

    public IEnumerator textEffect(params string[] s)
    {
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
