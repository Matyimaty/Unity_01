using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Space space = Space.World;
    [SerializeField, Range(1, 360)] float angularSpeed;
    // Update is called once per frame
    Stunnable stunnable;
    private void Start()
    {
        stunnable = FindObjectOfType<Stunnable>();

    }
    void Update()
    {
        // transform.RotateAround(transform.position, Vector3.up, angularSpeed * Time.deltaTime);     

        if (!stunnable.Stunned())
        {
            transform.Rotate(Vector3.up, angularSpeed * Time.deltaTime, space);
        }





    }

}
