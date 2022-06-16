using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllMeshRenderAndCollider : MonoBehaviour
{

    [SerializeField] List<GameObject> gameObjects;

    //megtalálja az öszes mesh rendert és collidert gameObjectet
    // Update is called once per frame
    void OnValidate()
    {
        
        Collider[] colliders = FindObjectsOfType<Collider>();
        gameObjects = new List<GameObject>();
   
        foreach (var item in colliders)
        {
            if (item.GetComponent<MeshRenderer>()!=null)
            {
                gameObjects.Add(item.gameObject);
     
            }
        }


    }/*
    [SerializeField] GameObject[] gameObjects;

    //megtalálja az öszes mesh rendert és collidert gameObjectet
    // Update is called once per frame
    void OnValidate()
    {

        Collider[] colliders = FindObjectsOfType<Collider>();
        gameObjects = new GameObject[colliders.Length];
        int i = 0;
        foreach (var item in colliders)
        {
            if (item.GetComponent<MeshRenderer>() != null)
            {
                gameObjects[i] = item.gameObject;
                i++;
            }
        }


    }*/
}
