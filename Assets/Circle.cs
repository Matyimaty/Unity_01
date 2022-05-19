using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{

    [SerializeField] float radius;


    [SerializeField] float division;
    [SerializeField] float area;


    // Update is called once per frame
    void OnValidate()
    {
        division = 2*radius* Mathf.PI;
        area =  radius* radius * Mathf.PI;
    }
}
