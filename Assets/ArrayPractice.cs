using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{

    [SerializeField] string[] arrayNames;
    [SerializeField] SphereCollider[] sphereArray;
    [SerializeField] Transform[] transformArray;
    [SerializeField] int[] intArray;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnValidate()
    {
        sphereArray = FindObjectsOfType<SphereCollider>();
        transformArray = GetComponentsInChildren<Transform>();
        
        intArray = new int[10];
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = i;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
