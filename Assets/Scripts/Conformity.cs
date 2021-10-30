using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conformity : MonoBehaviour
{
    [SerializeField]
    private int[] jouleArray = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
    [SerializeField]
    private int[] mJouleArray = new[] { 0, 0, 0, 0, 0, 0, 0, 11, 25, 38, 62, 75, 90, 112, 125, 145, 162, 175, 185, 200, 220 };

    public string NumberJoule(int i) => jouleArray[i].ToString();

    public string NumberMJoule(int i) => mJouleArray[i].ToString();

}
