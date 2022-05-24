using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField] Transform obj1;
    [SerializeField] Transform obj2;
    [Space]
    [SerializeField] float distance;
    void OnValidate()
    {
        Vector3  diff = obj1.position - obj2.position;
        distance = diff.magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
