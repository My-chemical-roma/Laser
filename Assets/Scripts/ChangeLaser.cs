using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLaser : MonoBehaviour
{
    [SerializeField]
    private Button Button;
    [SerializeField]
    private ParticleSystem colorRay;
    public GameObject cube;


    public void OnChangeColorGreen()
    {
        var main = colorRay.main;
        main.startColor = Color.green;
    }

    public void OnChangeColorRed()
    {
        var main = colorRay.main;
        main.startColor = Color.red;
    }
}
