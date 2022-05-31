using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;


    int collectedValue;

    private void Start()
    {
        FreshText();
    }
    public void AddToCollection(int price)
    {
        collectedValue += price;

            FreshText();
       
        
        //Debug.Log(collectedValue);
    }
    void FreshText()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {collectedValue}";
        }
    }
}
