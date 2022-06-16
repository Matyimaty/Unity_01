using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[RequireComponent(typeof(Player_Input), typeof(Rigidbody))]
public class PlayerMovementPhysics : MonoBehaviour
{
    [SerializeField] Player_Input playerInput;
    [SerializeField] Rigidbody rgbd;


    [SerializeField, Range(0.01f, 100)] float acceleration;
    [SerializeField, Range(0.01f, 100)] float maxSpeed;
    [SerializeField] float angularSpeed;
    [SerializeField] float jumpVelocity = 3;


    // Update is called once per frame

    private void OnValidate()
    {
        if (playerInput == null)
        {
            playerInput = GetComponent<Player_Input>();
        }
        if (rgbd == null)
        {
            rgbd = GetComponent<Rigidbody>();
        }
    }
    void Update()
    {
        HandleJumping();
    }

    void FixedUpdate()
    {
        HandleMovement();
        HandleTurning();
       
    }

    void HandleTurning()
    {
        float turn = playerInput.turn;
       /* if (turn == 0)
        {
            return;
        }
        else
        {
            // forgás torq forgató nyomaték! 
            rgbd.AddTorque(Vector3.up * angularSpeed * turn, ForceMode.Acceleration);
        }  
      */  
        rgbd.angularVelocity = Vector3.up * turn * angularSpeed;
        
    }

    void HandleJumping()
    {
        if (playerInput.jump)
        {
            rgbd.AddForce(Vector3.up * jumpVelocity, ForceMode.VelocityChange);
        }
       
    }

    void HandleMovement()
    {
        Vector3 inputVector = playerInput.movementVector;
        // a worldhöz képes mozog majd !!!!
        Vector3 finalInputVector = transform.TransformVector(inputVector);



        // ha így csináljuk nme kell delta timal szórakozni 
        rgbd.AddForce(finalInputVector.normalized * acceleration, ForceMode.Acceleration);

        float speed = rgbd.velocity.magnitude;
        
        if (speed>maxSpeed)
        {
            // max speed meghatározás
            // Elsõ:
            /* Vector3 vel = rgbd.velocity;
             rgbd.velocity = vel.normalized * maxSpeed;*/
            
            //2. verzió 
            /*
                        float multiplier = maxSpeed / speed;
                        Vector3 vel = rgbd.velocity;
                        rgbd.velocity *= multiplier;*/
            // verzió
            rgbd.velocity = Vector3.ClampMagnitude(rgbd.velocity, maxSpeed);

        }
    }
}
