using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 25;
    [SerializeField] float duration = 5;
    // Update is called once per frame

    float startTime;
    private void Start()
    {
        startTime = Time.time;   
    }
    void Update()
    {
        Vector3 movementVevtor = transform.forward.normalized; //transform.TransformVector(Vector3.forward);

        transform.position += movementVevtor * Time.deltaTime * speed;

        float age = Time.time - startTime;

        if (age > duration)
        {
            Destroy(gameObject);
        }
        




    }
    private void OnTriggerEnter(Collider other) // rigidbody iskinematik arra jó hogy mi  szaályozzuk a pozícióját, fizikaiba belszámolja a game objectet 
    {
        Blockable b = other.GetComponentInParent<Blockable>();
        if (b!=null)
        {
            b.Block();
        }
    }

}
