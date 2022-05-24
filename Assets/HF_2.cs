using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HF_2 : MonoBehaviour
{
    [SerializeField, Range(0, 1000)] int num;
    // Start is called before the first frame update
    void Start()
    {
        num = 30;
        int counter = 1;
        while (num >= counter)
        {
            if (counter % 3 == 0 || counter % 5 == 0)
            {
                if (counter % 3 == 0 && counter % 5 == 0)
                {
                    Debug.Log("fizzbuzz");
                }
                else if (counter % 3 == 0)
                {
                    Debug.Log("fizz");
                }
                else if (counter % 5 == 0)
                {
                    Debug.Log("buzz");
                }

            }
            else
            {
                Debug.Log(counter.ToString());
            }
            counter++;
        }





    }

}
