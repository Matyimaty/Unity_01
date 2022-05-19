using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feladat : MonoBehaviour
{
    [SerializeField] int num;
    [SerializeField] int count;

    // Update is called once per frame
    void OnValidate()
    {
        for (int i = 1; i <= num; i++)
        {
            count = 0;
            if (num%i ==0)
            {
                count++;
            }
            Debug.Log(i);
        }
    }
}
