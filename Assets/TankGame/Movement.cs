using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField, Range( 0.01f,15)] float speed;
    [SerializeField] float angularSpeed;

    // Update is called once per frame
    void Update()
    {
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);
        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);

        float x = right ? 1 : (left ? -1 : 0);
        float z = up ? 1 : (down ? -1 : 0);

        Vector3 inputVector = new Vector3 (x, 0, z);
      //  Debug.Log(inputVector);
        // delta time azért kell mert nem függ az FPS tõl a cucc A normalizált azért
        // kell mert ha átlósan megyünk akkor így fog menni olyan sebességel, hogy megfelelõen minden irányban. 
        
        
        
        // Queaterion arra néz a karakter amerre megy! 
        if (inputVector != Vector3.zero)
        {
            transform.position += inputVector.normalized * Time.deltaTime * speed;
           
            Quaternion tartgetRotation = Quaternion.LookRotation(inputVector);
           // transform.rotation = Quaternion.LookRotation(inputVector);
            Quaternion resultRotation =  Quaternion.RotateTowards(transform.rotation, tartgetRotation, angularSpeed *Time.deltaTime);
            transform.rotation = resultRotation; 
        }
        

        /*
                if (right)
                    transform.position += new Vector3(0.01f, 0, 0);

                if (left)
                    transform.position += new Vector3(-0.01f, 0, 0);
                if (up)
                    transform.position += new Vector3(0, 0, 0.01f);
                if (down)
                    transform.position += new Vector3(0, 0, -0.01f);
        */






    }
}
