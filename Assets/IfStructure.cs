using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStructure : MonoBehaviour
{
    // három tipusú vezérlési szerkezet van


    [SerializeField] float characterHeight;
    [SerializeField] float enemy1Height;
    [SerializeField] float enemy2Height;


    [SerializeField] bool areWeWinning;
    [SerializeField] string state;
    void OnValidate()
    {
        areWeWinning = characterHeight > enemy1Height && characterHeight > enemy2Height;



        state = areWeWinning ? "winnin" : "loosing";
        if (areWeWinning)
        {
            Debug.Log("WINNING");
            state = "Winning";
        }
        else
        {
            Debug.Log("LOOSING");
            state = "LOOSING";
        }

    }
}
