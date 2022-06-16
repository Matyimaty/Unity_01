using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] Player_Input input;

    [Header("shooting")]
    [SerializeField] GameObject projectilePrototype;
    [SerializeField] Transform shootingPosition;

    [SerializeField] int projectileCount = 3;
    [SerializeField] float projectileDelay = 0.1f;


    void Update()
    {
        if (input.shoot)
        {
            StartCoroutine(StartShot());
            // shot helyett a fenti Coroutine amivel �j sz�l indul majd
            //Shoot();
        }
    }

    // Sz�lkezel�s !! kb .... olyan minta new thread coorutin
    IEnumerator StartShot()
    {
        for (int i = 0; i < projectileCount; i++)
        {
            Shoot();
            yield return new WaitForSeconds(projectileDelay);
        }
        
        
    }
    public void Shoot()
    {
        // P�ld�nyos�t l�tre hoz egy �j objektumot.
        GameObject newGameObject = Instantiate(projectilePrototype);
        newGameObject.transform.position = shootingPosition.position;
        newGameObject.transform.rotation = shootingPosition.rotation;


        Debug.Log("BangBang");
    }

}
