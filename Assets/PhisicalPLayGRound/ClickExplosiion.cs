using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickExplosiion : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Camera cam;
    [SerializeField] float explosenForce;
    [SerializeField] float explosenRadius;
    [SerializeField] float explosenUpperModifier;

    void OnValidate()
    {
        if (cam== null)
        {
           // cam = FindObjectOfType<Camera>();
            cam = Camera.main;
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            // kamare raynek a vége ahova kattinutnk az fog felrobbanni majd... ez az a végpontja 
            Vector2 mousePos = Input.mousePosition;
            Ray mouseRay =  cam.ScreenPointToRay(mousePos);
            if (Physics.Raycast(mouseRay, out RaycastHit hitInfo, 1000))
            {
                Debug.Log($"clicked{hitInfo.collider.name}   {hitInfo.point}");
                transform.position = hitInfo.point;

                Rigidbody[] allBodies = FindObjectsOfType<Rigidbody>();


                foreach (var item in allBodies)
                {
                    item.AddExplosionForce(explosenForce,hitInfo.point,explosenRadius,explosenUpperModifier,ForceMode.Impulse);
                }

            }
            



            


        }
        
        
    }
    private void OnDrawGizmos()
    {
        Vector2 mousePos = Input.mousePosition;
        Ray mouseRay = cam.ScreenPointToRay(mousePos);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(mouseRay.origin, mouseRay.origin + mouseRay.direction * 100);

    }
}
