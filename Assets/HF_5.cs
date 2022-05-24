using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HF_5 : MonoBehaviour
{
    [SerializeField, Range(0, 1000)] int a;
    [SerializeField, Range(0, 1000)] int b;
    [SerializeField, Range(0, 1000)] int c;
    [Space]
    [SerializeField] bool isPytagorian;
    // Start is called before the first frame update
    void OnValidate()
    {
        isPytagorian = (a * a) + (b * b) == (c * c);
    }


}
