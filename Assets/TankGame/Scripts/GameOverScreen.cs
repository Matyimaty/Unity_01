using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] Canvas canvasToTurnOn;
    [Space]
    [SerializeField] Damagable[] damagable;
    [SerializeField] ResetPosition[] resetPosition;



    private void OnValidate()
    {
        if (canvasToTurnOn == null)
        {
            canvasToTurnOn = GetComponent<Canvas>();
        }

        damagable = FindObjectsOfType<Damagable>();
        resetPosition = FindObjectsOfType<ResetPosition>();
    }
    void Update()
    {
        bool isAllDamagableDead = true;
        /* if (isBothDamagableDead)
         {
             canvasToTurnOn.enabled = true;
         }*/
        for (int i = 0; i < damagable.Length; i++)
        {
            bool isDead = damagable[i].health == 0;
            if (!isDead)
            {
                isAllDamagableDead = false;
                
                break;
            }
        }


        
        canvasToTurnOn.enabled = isAllDamagableDead;
    }
    public void Restart()
    {
        for (int i = 0; i < damagable.Length; i++)
        {
            damagable[i].Resurrect();
        }


        for (int i = 0; i < resetPosition.Length; i++)
        {
            resetPosition[i].restart();
        }


    }
}
