using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public GameObject panel;
    public Text dialog;
    public Text next;
    
    [TextArea(3,10)]
    public string[] message;
    public string[] press;
    
    private int _i = 0;
    private bool _flag = true;

    void Start()
    {
        dialog.text = message[_i];
        next.text = press[_i];
        _i++;
    }

   void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)&&_flag&&_i<message.Length)
        {
            dialog.text = message[_i];
            _i++;
            _flag = false;
            if (_i == message.Length)
            {
                next.text = press[1];
            }
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            _flag = true;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
