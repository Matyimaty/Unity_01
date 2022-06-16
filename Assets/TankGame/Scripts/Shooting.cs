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
            // shot helyett a fenti Coroutine amivel új szál indul majd
            //Shoot();
        }
    }

    // Szálkezelés !! kb .... olyan minta new thread coorutin
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
        // Példányosít létre hoz egy új objektumot.
        GameObject newGameObject = Instantiate(projectilePrototype);
        newGameObject.transform.position = shootingPosition.position;
        newGameObject.transform.rotation = shootingPosition.rotation;


        Debug.Log("BangBang");
    }

}
