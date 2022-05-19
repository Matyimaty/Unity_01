using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] float c;
    [SerializeField] float d;

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] int abs;
    [SerializeField] float round;
    [SerializeField] float result;
    void OnValidate()
    {
        max = Mathf.Max(a, b);
        min = Mathf.Min(a, b);
        abs = AboluteValue(a);
        round = Rounded_1(c);
        result = POW_1(c,a);

    }
    int AboluteValue(int input)
    {

        if (input >= 0)
        {
            return input;
        }
        else
        {
            // return input * -1;
            return -input;

        }

    }
    float Rounded_1(float input)
    {
        float fraction = input % 1;
        if (fraction < 0.5f)
        {
            return input - fraction;
        }
        else
        {
            return input - fraction + 1;
        }

    }
    float POW_1(float a, int x)
    {
        float sum =  a;
        int counter = 0;
        while (x < counter)
        {
            sum = a * sum;
            counter++;
        }
        return sum;

    }




}

