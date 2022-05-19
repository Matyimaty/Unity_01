using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanPractice : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;

    [Space]
    // output
    [SerializeField] bool IsEqual;
    [SerializeField] bool numISSmaller;
    [SerializeField] bool numisBIgger;
    [SerializeField] bool numISSmallerOREqual;
    [SerializeField] bool numisBIggerOREqual;

    [Header("OR operator")]
    [SerializeField] bool isBig;
    [SerializeField] bool isCheap;
    [Space]
    [SerializeField] bool bringWashingPowder;

    [Header("And operator")]
    [SerializeField] bool paprika;
    [SerializeField] bool potato;
    [Space]
    [SerializeField] bool cook;
    [SerializeField] bool cantNOTCook;



    void OnValidate()
    {
        bringWashingPowder = isBig || isCheap;
        cook = paprika && potato;
        cantNOTCook = !cook;

        







        IsEqual = num1 == num2;
        numISSmaller = num1 < num2;
        numisBIgger = num1 > num2;
        numISSmallerOREqual = num1 <= num2;
        numisBIggerOREqual = num1 >= num2;


    }
}
