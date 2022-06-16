using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatArray : MonoBehaviour
{
    [SerializeField] float[] inputArray;
    [SerializeField] float summa;
    [SerializeField] float product;
    [SerializeField] float mean;
    void OnValidate()
    {
        if (inputArray.Length>0)
        {


            summa = inputArray[0];
            product = inputArray[0];

            for (int i = 1; i < inputArray.Length; i++)
            {
                summa += inputArray[i];
                product *= inputArray[i];
            }
            mean = summa / inputArray.Length;
        }
        else
        {
            product = 0;
            mean = 0;
            summa = 0;
        }
    }

}
