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
        UpdatePosition();
    }


    // kirajzol gizm�kat, ahol a pontok vannak �gy egyszer�bb a n�zeten megl�tni merre megy majd a karakter vagy b�rmi m�s 
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
