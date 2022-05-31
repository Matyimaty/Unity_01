using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecteble : MonoBehaviour
{

    [SerializeField ,Range(1,10)] int price;
    [SerializeField] Bounds teleportArea;
    void OnTriggerEnter(Collider other)
    {
        Collector collect = other.GetComponent<Collector>();
        if (collect != null)
        {
            Debug.Log($"Collectible {collect.name}");
            collect.AddToCollection(price);
            Teleport();
        }
    }
    void Teleport()
    {
        float randomX = Random.Range(teleportArea.min.x, teleportArea.max.x); 
        float randomY = Random.Range(teleportArea.min.y, teleportArea.max.y);
        float randomZ = Random.Range(teleportArea.min.z, teleportArea.max.z);
        transform.position = new Vector3(randomX, randomY, randomZ);

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireCube(teleportArea.center,teleportArea.size);
    }
}
