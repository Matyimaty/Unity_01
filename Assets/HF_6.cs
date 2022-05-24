using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HF_6 : MonoBehaviour
{
    [SerializeField, Range(0, 1000)] int inputnumber;
  
    [Space]
    [SerializeField] bool isPrime;
    // Start is called before the first frame update
    void Start()
    {
        inputnumber = 100;
        int count = 0;
        for (int i = 2; count < inputnumber; i++)
        {
            if (isPrime = IsPrime(i))
            {
                count++;
                Debug.Log(i);
            }
        }


       
    }
    bool IsPrime(int n)
    {
        if (n <= 1)
        {
                return false;
        }
        for (int i = 2; i <= n/2; i++)
        {
            if (n%i == 0)   
            return false;
        }
        return true;   
    }

}
