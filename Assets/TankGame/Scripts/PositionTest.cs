using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // local position mindenig a jelenlegi objectnek adja vissza tényleges local position, hogy 
        Debug.Log(transform.position);
        Debug.Log(transform.localPosition);
    }

    // Update is called once per frame
 
}
