using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HF_3 : MonoBehaviour
{
    [SerializeField] string text ="";
    [SerializeField] string text1 = "";
    [SerializeField] string text2 = "";
    [SerializeField] string text3 = "";

    [Space]
    [SerializeField] int count = 0;
    [SerializeField] string all = "";
    // Update is called once per frame
    void OnValidate()
    {
        count = text.Trim().Length;
        all = text_flow(text1, text2, text3);


    }
    string text_flow(string s1, string s2, string s3)
    {
        string all = "";
        if (s1 != "" && s2 != "" && s3 != "")
        {

            all = s1 + ", " + s2 + ", " + s3;
            return all;
        }
        else
        {
            return "";
        }


    }
}
