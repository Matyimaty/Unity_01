using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalindromTest : MonoBehaviour
{
    [SerializeField] string textToTest;
    [SerializeField] bool isPalindrom;

    // Start is called before the first frame update
    void OnValidate()
    {
        IsPalindrom(textToTest);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    bool IsPalindrom(string text) {
        string reversedString;
        int l = text.Length;
        char[] charArray = text.ToCharArray();
        char[] reverse = new char[charArray.Length];
        // indul a gorog aludn
        for (int i = 0; i < l; i++)
        {
            reverse[i] = charArray[l-1-i];
        }
        reversedString = new string(reverse);

         isPalindrom =    text == reversedString;
        return isPalindrom;
    }
}
