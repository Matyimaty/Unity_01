using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockable : MonoBehaviour
{
    // Start
    // is called before the first frame update
    [SerializeField] Collider colliderToTurnOn;
    [SerializeField] MonoBehaviour componentTurnOn;
    [SerializeField] float blockingDuration = 5;
    [SerializeField] new ParticleSystem particleSystem;

    float blockingTime;
    bool isBlocked = false;



    private void OnValidate()
    {
        if (colliderToTurnOn == null)
        {
            colliderToTurnOn = GetComponentInChildren<Collider>();
        }
    }
    public void Block()
    {
        if (particleSystem != null)
        {
            particleSystem.Play();
        }
        



        colliderToTurnOn.enabled = false;
        componentTurnOn.enabled = false;
        blockingTime = Time.time;
        isBlocked = true;


    }
    void UnBlock()
    {
        colliderToTurnOn.enabled = true;
        componentTurnOn.enabled = true;
       isBlocked = false;

    }
    void Update()
    {
 
        if ( isBlocked && blockingTime + blockingDuration < Time.time)
        {
            UnBlock();
        }
    }



}
