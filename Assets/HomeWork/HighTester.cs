using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighTester : MonoBehaviour
{
    // Start is called before the first frame update
    bool isAboveLastFrame;

    // Update is called once per frame
    void Update()
    {
        bool isAbove0 = transform.position.y > 0;

        if (isAbove0 != isAboveLastFrame)
        {
            if (isAbove0)
            {
                Debug.Log("Crossed Zero UP");
            }
            else
            {
                Debug.Log("Crossed Zero Down");
            }
        }
        isAboveLastFrame = isAbove0;
    }
}
