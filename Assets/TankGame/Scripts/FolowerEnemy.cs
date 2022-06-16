using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowerEnemy : MonoBehaviour
{

    [SerializeField] Transform[] followables;
    [SerializeField] AnimationCurve speedFunction;

    //  [SerializeField] float angularSpeed;


    // Update is called once per frame
    void Update()
    {
        Vector3 selfpoz = transform.position;
        int closestIndex = 0;
        float min = Vector3.Distance(followables[0].position, selfpoz);
        for (int i = 1; i < followables.Length; i++)
        {
            float d = Vector3.Distance(followables[i].position, selfpoz);
            if (d < min)
            {
                min = d;
                closestIndex = i;
            }
        }




        Vector3 targetPos = followables[closestIndex].position;

        targetPos.y = transform.position.y;

        // Vector3 movementVector = targetPos - transform.position;
        //transform.position += inputVector.normalized * Time.deltaTime * speed;
        // Az ez alatti fügvény a villogást szûnteti meg ha egy pozícióban vannak
        // transform.position += movementVector.normalized * Time.deltaTime * speed;

        // itt lehetne használni a movement vector pozició hosszát is vagy is movementVector.
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
        // arra néz a kaakter amerre megyünk ez pont ehhez kell

        if (movementVector != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movementVector);
        }

    }
}
