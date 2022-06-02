using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTestScript : MonoBehaviour
{

    [SerializeField] float[] numbers;
    [Space]
    [SerializeField] float avg;

    void OnValidate()
    {
        float sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        avg = sum / numbers.Length;
    }

}
