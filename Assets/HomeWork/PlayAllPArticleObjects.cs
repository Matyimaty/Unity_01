using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAllPArticleObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem[] particleSytems = FindObjectsOfType<ParticleSystem>();
        foreach (var item in particleSytems)
        {
            item.Play();
           
        }
    }

} // Update is called once per frame
  
