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
    public void OnChangeColorRedButton()
    {
        var main = colorRay.main;
        main.startColor = Color.red;
    }
    public void OnChangeColorRed(ParticleSystem system)
    {
        var main = system.main;
        main.startColor = Color.red;
    }

    public void OffColor(ParticleSystem system)
    {
        var main = system.main;
        main.startColor = new Color(0, 0, 0, 0f);
    }
}
