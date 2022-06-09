using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stunnable : MonoBehaviour
{

    [SerializeField] float timeStunSec = 5;
    [SerializeField] Behaviour componentStopMovingOn;
    [SerializeField] new ParticleSystem particleSystem;

    float startTime;
    bool stun;
    Slicer slicer;
    // Start is called before the first frame update
    void Start()
    {
        stun = false;
        slicer = FindObjectOfType<Slicer>();
    }

    private void Update()
    {
        if (stun)
        {
            float age = Time.time - startTime;

            if (age > timeStunSec)
            {

                stun = false;
                this.gameObject.GetComponent<Collider>().enabled = true;
                componentStopMovingOn.enabled = true;


            }
        }
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        Projectile projectile = other.gameObject.GetComponent<Projectile>();
        if (projectile != null)
        {
            this.gameObject.GetComponent<Collider>().enabled = false;
            stun = true;
            startTime = Time.time;
            Destroy(other.gameObject);
            componentStopMovingOn.enabled = false;
            particleSystem.Play();



        }

        Debug.Log("Stun");

        //this.gameObject.
        // blokkable tipusok le�llnak! az enemyre kell r�h�zni ezt a cuccost!
        // ha letelik az id� akkor �jra 
        // kolider kikapcsol�sa ilyenkore ne tudjanak sebezni
    }
}
