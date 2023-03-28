using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(buttonClicked);
    }
    void buttonClicked()
    {
        SceneManager.LoadScene("DirectoryView");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
