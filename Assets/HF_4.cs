using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HF_4 : MonoBehaviour
{

    [SerializeField, Range(0, 100)] int number;
    [Space]
    [SerializeField] string outputstring;
    // Start is called before the first frame update
    void OnValidate()
    {
        outputstring = "";
        for (int i = 0; i <= number; i++)
        {
            if (i==number)
            {
                outputstring += i;
            }
            else
            {
                outputstring += i + ", ";
            }
            
        }
    }

}
