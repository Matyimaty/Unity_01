using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpareTrap : MonoBehaviour
{
    [SerializeField] Transform center;
    [SerializeField] float radius;

    // Update is called once per frame
    void Update()
    {
        Vector3 selfPos = transform.position;
        Vector3 centerPos = center.position;

        Vector3 distanceVector = selfPos - centerPos;

        bool isOutsideOfSpare = distanceVector.magnitude > radius;
        if (isOutsideOfSpare)
        {
            transform.position = centerPos+( distanceVector.normalized * radius);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(center.position,radius);
    }
}
