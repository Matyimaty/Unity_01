using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer2 : MonoBehaviour
{
    [SerializeField, Range(0.01f, 15)] float speed;
    [SerializeField] float angularSpeed;
    [Space]
    [SerializeField] Transform circlePoint;
    [SerializeField, Range(1, 10)] float radius;

    // Update is called once per frame
    void Update()
    {
        bool right = Input.GetKey(KeyCode.D);
        bool left = Input.GetKey(KeyCode.A);
        bool up = Input.GetKey(KeyCode.W);
        bool down = Input.GetKey(KeyCode.S);

        float x = right ? 1 : (left ? -1 : 0);
        float z = up ? 1 : (down ? -1 : 0);

        Vector3 inputVector = new Vector3(x, 0, z);
        //  Debug.Log(inputVector);
        // delta time az?rt kell mert nem f?gg az FPS t?l a cucc A normaliz?lt az?rt
        // kell mert ha ?tl?san megy?nk akkor ?gy fog menni olyan sebess?gel, hogy megfelel?en minden ir?nyban. 



        // Queaterion arra n?z a karakter amerre megy! 
        if (inputVector != Vector3.zero)
        {
            transform.position += inputVector.normalized * Time.deltaTime * speed;

            Quaternion tartgetRotation = Quaternion.LookRotation(inputVector);
            // transform.rotation = Quaternion.LookRotation(inputVector);
            Quaternion resultRotation = Quaternion.RotateTowards(transform.rotation, tartgetRotation, angularSpeed * Time.deltaTime);
            transform.rotation = resultRotation;


            // HF hogy ha kimegy a k?rb?l akkor reset position

            float disttance = Vector3.Distance(circlePoint.position, transform.position);
            if (disttance > radius)
            {
                transform.position = circlePoint.position;
            }
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
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(circlePoint.position, radius);
    }
}
