using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnitude : MonoBehaviour
{
    [SerializeField] Vector2 vector;
    [Space]
    [SerializeField] float distance;
    [Space]
    [SerializeField] float magnitude2;
    void OnValidate()
    {

        distance = vector.magnitude ;
        magnitude2 = GetMagnitude(vector);



    }

    float GetMagnitude(Vector2 vector)
    {
        float sqrX = vector.x * vector.x;
        float sqrY = vector.y * vector.y;
       return MathF.Sqrt(sqrX + sqrY);
    }
}
