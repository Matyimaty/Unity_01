using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorPractice : MonoBehaviour
{
    [SerializeField] Vector2 inputV2;
    [SerializeField] Vector3 inputV3;
    [Space]
    [SerializeField] Vector3 outputV4;
    [SerializeField] Vector2 outputV5;
    [Space]
    [Space]
    [SerializeField] Vector2 inputV2_1;
    [SerializeField] Vector2 inputV2_2;
    [SerializeField] float number;
    [SerializeField] Vector2 summa;
    [Space]
    [SerializeField] Vector2 difference;
    [SerializeField] Vector2 product;

    void OnValidate()
    {

        Vector2 v2 = new Vector2(2,3.5f);
        Vector3 v3 = new Vector3(3,5,-7);

        Vector3 v4 = v2;
        outputV4 = inputV2;
        outputV5 = inputV3;

        summa = inputV2_1 + inputV2_2;
        difference = inputV2_1 - inputV2_2;
        product = inputV2_1 * number;    
    }

}
