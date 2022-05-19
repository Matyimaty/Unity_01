using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopStructure : MonoBehaviour
{
    [SerializeField] int n;

    void Start()
    {
        /* int num = 1;

         while (num<=10)
         {
             Debug.Log(num.ToString());
             num++;
         }





         for (int i = 0; i < 11; i++)
         {
             Debug.Log(i.ToString());
         }

         */
        /*
        while (num <= 10)
        {
            if (num % 3 ==0 || num % 7 == 0)
            {
                Debug.Log(num.ToString());
            }
         
            num++;
        }
        */
        /*
        do
        {

        } while (true);
       */

       /* for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Debug.Log($"{i} * {i}");
            }

        }*/
        for (int i = 10; i >= 0; i--)
        {
            Debug.Log($"{i}");

        }

    }

}
