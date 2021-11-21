using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    [SerializeField]
    private string[] str;
    public GameObject panel;
    public Text dialog;
    [SerializeField]
    private int j = 0;

    void Start()
    {
        StartCoroutine(RuningText(j));
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.R) && dialog.text.Length == str[j].Length && str.Length - 1 > j)
        {
            StartCoroutine(RuningText(++j));
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            gameObject.active = false;
        }
    }
    public IEnumerator RuningText(int j)
    {
        dialog.text = "";
        for (var i = 0; i < str[j].Length; i++)
        {
            char s = str[j][i];
            dialog.text += s;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
