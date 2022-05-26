using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagable : MonoBehaviour
{
    [SerializeField] int health;

    public void Damage(int damage)
    {
       health -= damage;
        if (health<=0)
        {
            Debug.Log("You are dead Mother fucker!");
        }
    }
}
