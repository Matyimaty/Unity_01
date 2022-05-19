using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    [SerializeField] float number1;
    [SerializeField] float number2;

    [SerializeField] float sum;
    [SerializeField] float difference;
    [SerializeField] float product;
    [SerializeField] float ratio;



    // Start is called before the first frame update
    void OnValidate()
    {
        sum = number1 + number2;
        difference = number1 - number2;
        product = number2 * number1;
        ratio = number1 / number2;
    }

}
