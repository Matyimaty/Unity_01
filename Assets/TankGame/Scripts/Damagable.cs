using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Damagable : MonoBehaviour
{

    [SerializeField] TMP_Text healthText;

    [SerializeField] int starthealth;
    [SerializeField] Behaviour componentToTurnOn;


    public int health;



    // componenetet igy kell kódból bekötni, hogy ha nem raktuk be onvalidatebe egybõl belekötötte 
    private void OnValidate()
    {
        if (componentToTurnOn == null)
        {
            componentToTurnOn = GetComponentInParent<Movement>();
        }
    }

    private void Start()
    {
        health = starthealth;
        FreshText();
    }
    public void Damage(int damage)
    {

        if (health == 0)
        {
            return;
        }

        health -= damage;
        if (health <= 0)
        {
            Debug.Log("You are dead Mother fucker!");
            health = 0;
            componentToTurnOn.enabled = false;
        }

        FreshText();
    }
    void FreshText()
    {
        if (healthText != null)
        {
            healthText.text = $"Health: {health}";
        }

    }
    public void Resurrect()
    {
        componentToTurnOn.enabled = true;
        health = starthealth;
        FreshText();




    }
}
