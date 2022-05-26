using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] int damage;


    // ez a zt jelenti, hogy �tk�zt�nk valamivel
    // Amikor megt�rt�nt az �tk�z�s param�terk�nt �tadja, �s a m�sikt�l letudja k�rdezni, hogy van -e Damagable v�ltoz�ja. 
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
