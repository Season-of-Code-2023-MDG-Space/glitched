using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System;
using System.Threading.Tasks;
namespace CoolBoi{
public class InputExample : MonoBehaviour
{
    public static InputField inputField;

    public static async Task<string> WaitForInput()
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
}
}