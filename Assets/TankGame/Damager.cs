using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] int damage;


    // ez a zt jelenti, hogy ütköztünk valamivel
    // Amikor megtörtént az ütközés paraméterként átadja, és a másiktól letudja kérdezni, hogy van -e Damagable változója. 
    void OnTriggerEnter(Collider other)
    {
       // Debug.Log("Collison");
        Damagable damagable =  other.GetComponent<Damagable>();
        if (damagable != null)
        {
            Debug.Log($"Collison {damagable.name}");
            damagable.Damage(damage);
        }
    }
}
