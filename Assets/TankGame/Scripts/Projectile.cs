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
    
}
