using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OutputOfIndicators : MonoBehaviour
{
    [SerializeField]
    private int i = 1;
    private TextMeshProUGUI textMesh;
    private Conformity conformity = new Conformity();
    void Start() => textMesh = gameObject.GetComponent<TextMeshProUGUI>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShowText();
            if (i < 21)
                i++;
        }

        if (Input.GetMouseButtonDown(1))
        {
            ShowText();
            if (i > 0)
                i--;
        }
    }

    void ShowText()
    {
        //textMesh.text = conformity.NumberJoule(i); - для второго датчика.
        textMesh.text = conformity.NumberMJoule(i);
    }
}
