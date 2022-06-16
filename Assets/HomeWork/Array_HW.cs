using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array_HW : MonoBehaviour
{

    [SerializeField, Min(0)] int arraySize = 5;
    [SerializeField] int[] intArray;
    // Start is called before the first frame update
    void OnValidate()
    {
        intArray = new int[arraySize];

        int count = 0;

        for (int i = 1; count < intArray.Length; i++)
        {
            if (i % 7 ==0 && i % 3 == 0)
            {
                intArray[count] = i;
                count++;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
