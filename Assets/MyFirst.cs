using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirst : MonoBehaviour
{

    // Valami sz�veg k
    /// <summary>
    /// Void start sz�veg :D 
    /// </summary>
    /// 
    [SerializeField, Min(2)] int inputNumber;
    [SerializeField, Range(0,100)] float inputFloat;
    [SerializeField] string inputtext;
    [SerializeField] bool inputBool;
    void Start()
    {
        Debug.Log(inputNumber);
        Debug.Log(inputFloat);
        Debug.Log(inputtext);
        Debug.Log(inputBool);

        Debug.Log(inputNumber+inputFloat);



    }
    void OnValidate()
    {
        inputtext = $"eredmeny�: {inputNumber+inputFloat} ";
    }
}
