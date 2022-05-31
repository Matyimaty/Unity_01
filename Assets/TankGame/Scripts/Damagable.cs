using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Damagable : MonoBehaviour
{

    [SerializeField] TMP_Text healthText;

    [SerializeField] int health;

    private void Start()
    {
        FreshText();
    }
    public void Damage(int damage)
    {
       health -= damage;
        if (health<=0)
        {
            Debug.Log("You are dead Mother fucker!");
        }
        
    }
    void FreshText() {
        if (healthText != null)
        {
            healthText.text = $"Health: {health}";
        }
        
    }
}
