using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avarage : MonoBehaviour
{

    [SerializeField] float number1;
    [SerializeField] float number2;
    [SerializeField] float number3;

    [SerializeField] float avarage;

    // Update is called once per frame
    void OnValidate()
    {
        avarage = (number1+number2+number3)/3;
    }
}
