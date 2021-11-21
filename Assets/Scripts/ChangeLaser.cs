using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLaser : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem ray;
    [SerializeField]
    private TextMeshProUGUI output;
    [SerializeField]
    private TextMeshProUGUI input;
    public bool isRed;

    public void OnActivateLaserGreen()
    {
        isRed = false;
        input.text = "0Äæ";
        output.text = "0ìÄæ";
        ray.Stop();
    }
    public void OnActivateLaserRed()
    {
        isRed = true;
        input.text = "0Äæ";
        output.text = "0ìÄæ";
        ray.Stop();
    }
    public void StartGreenLaser()
    {
        var main = ray.main;
        main.startColor = Color.green;
        ray.Play();
    }
    public void StartRedLaser()
    {
        var main = ray.main;
        main.startColor = Color.red;
        ray.Play();
    }
    public void StopLaser()
    {
        ray.Stop();
    }
}
