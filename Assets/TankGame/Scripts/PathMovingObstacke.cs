using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMovingObstacke : MonoBehaviour
{

    [SerializeField] Transform point1;
    [SerializeField] Transform point2;
    [SerializeField] float speed;
    [SerializeField ,Range(0,1)] float t;

    float time;
    bool up;
    bool positiv = false;
    bool negativ = false;
    // Update is called once per frame


    private void OnValidate()
    {
        UpdatePosition();
    }
    void Update()
    {

        float disttance = Vector3.Distance(point1.position,point2.position);
        if (up)
        {
            t += Time.deltaTime / disttance * speed ;
            if (t > 1)
            {
                up = false;
            }
        }
        else
        {
            t -= Time.deltaTime / disttance * speed;
            if (t < 0)
            {
                up = true;
            }
        }


        /// HF 
        /// 
       
        Vector3 actualPosition = transform.position;
        if (actualPosition.y <0 && !negativ)
        {
            Debug.Log("Cross Zero-");
            negativ = true;
            positiv = false;
        }
        if (actualPosition.y >0 && !positiv)
        {
            positiv = true;
            negativ = false;
            Debug.Log("Cross Zero+");
        }


        UpdatePosition();
    }


    // kirajzol gizmókat, ahol a pontok vannak így egyszerûbb a nézeten meglátni merre megy majd a karakter vagy bármi más 
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(point1.position, 0.5f);
        Gizmos.DrawWireSphere(point2.position, 0.5f);
        Gizmos.DrawLine(point1.position, point2.position);
    }
    private void UpdatePosition()
    {
        transform.position = Vector3.Lerp(point1.position, point2.position, t);

    }
}
