using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Input : MonoBehaviour
{
    [SerializeField] PlayerInput input;
    // Start is called before the first frame update
    InputAction movementAction;
    InputAction shootAction;
    InputAction jumpingAction;
    InputAction turnAction;


    public Vector3 movementVector;
    public bool shoot;
    public bool jump;
    public float turn;

    void Start()
    {
        movementAction = input.currentActionMap.FindAction("Movement");
        shootAction = input.currentActionMap.FindAction("Shooting");
        jumpingAction = input.currentActionMap.FindAction("Jumping");
        turnAction = input.currentActionMap.FindAction("Turning");
    }
     void Update()
    {
        
        movementVector = movementAction.ReadValue<Vector3>();
        shoot = shootAction.triggered;
        jump = jumpingAction.triggered;
        turn = turnAction.ReadValue<float>();

    }

    // Update is called once per frame
}
