using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValieSwap : MonoBehaviour
{
    [SerializeField] string text1 = "AAA";
    [SerializeField] string text2 = "BBB";
    // Start is called before the first frame update
    void Start()
    {
        string temp = text1;
        text1 = text2;
        text2 = temp;
    }


}
