using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OutputOfIndicators : MonoBehaviour
{
    [SerializeField]
    private int i = 0;
    [SerializeField]
    private ParticleSystem raySystem;
    [SerializeField]
    private TextMeshProUGUI output;
    [SerializeField]
    private TextMeshProUGUI input;
    private Conformity conformity = new Conformity();
    private ChangeLaser changeLaser = new ChangeLaser();

    public void OnClickPlus()
    {
        if (i < 20)
        {
            i++;
        }
        ShowTextLaserRed();
        if (int.Parse(conformity.NumberMJoule(i)) == 11)
            changeLaser.OnChangeColorRed(raySystem);
    }
    public void OnClickMines()
    {
        if (i > 0)
        {
            i--;
        }
        ShowTextLaserRed();
        if (int.Parse(conformity.NumberMJoule(i)) < 11)
            changeLaser.OffColor(raySystem);
    }

    void ShowTextLaserRed()
    {
        input.text = conformity.NumberJoule(i);
        output.text = $"{conformity.NumberMJoule(i)}Дж.";
    }
    void ShowTextLaserGreen()
    {
        input.text = conformity.NumberMJoule(i);
    }
}
