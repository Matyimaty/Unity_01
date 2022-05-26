using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowerEnemy : MonoBehaviour
{

    [SerializeField] Transform followable;
    [SerializeField] AnimationCurve speedFunction;

  //  [SerializeField] float angularSpeed;

    // Update is called once per frame
    void Update()
    {

        Vector3 targetPos = followable.position;

        // Vector3 movementVector = targetPos - transform.position;
        //transform.position += inputVector.normalized * Time.deltaTime * speed;
        // Az ez alatti f�gv�ny a villog�st sz�nteti meg ha egy poz�ci�ban vannak
        // transform.position += movementVector.normalized * Time.deltaTime * speed;

        // itt lehetne haszn�lni a movement vector pozici� hossz�t is vagy is movementVector.
        float distance = Vector3.Distance(targetPos, transform.position);
        float speed = speedFunction.Evaluate(distance);

        float maxDistance = Time.deltaTime * speed;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, maxDistance);


        // Quaternion tartgetRotation = Quaternion.LookRotation(inputVector);
        /*  Quaternion tartgetRotation = Quaternion.LookRotation(movementVector);



          //Quaternion resultRotation =  Quaternion.RotateTowards(transform.rotation, tartgetRotation, angularSpeed *Time.deltaTime);
          Quaternion resultRotation = Quaternion.RotateTowards(transform.rotation, tartgetRotation, angularSpeed * Time.deltaTime);
          transform.rotation = resultRotation;*/

        Vector3 movementVector = targetPos - transform.position;
        // arra n�z a kaakter amerre megy�nk ez pont ehhez kell

        if (movementVector!= Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movementVector);
        }
       
    }
}
