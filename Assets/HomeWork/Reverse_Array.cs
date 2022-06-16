using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reverse_Array : MonoBehaviour
{

    [SerializeField] string[] inputArray;
    [SerializeField] string[] outputArray;

    // Update is called once per frame
    void OnValidate()
    {
        

        for (int i = 0; i < inputArray.Length; i++)
        {
            outputArray[i] = inputArray[inputArray.Length -1 -i];
        }
    }
}
