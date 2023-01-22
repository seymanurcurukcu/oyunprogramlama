using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AracBinme : MonoBehaviour
{
   
    public GameObject player;
    public GameObject players;
    public GameObject TheCar;
    public int TriggerCheck;
    public GameObject DigerArac1;
    public GameObject DigerArac2;
    public GameObject planeTrigger;
   

    private void OnTriggerEnter(Collider other)
    {
        TriggerCheck = 1;
    }
    private void OnTriggerExit(Collider other)
    {
        TriggerCheck = 0;
    }
   
 
    private void Update()
    {

        if (TriggerCheck==1)
        {

               if (!DigerArac1.activeSelf && !DigerArac2.activeSelf)
                {
               
              
                TriggerCheck = 0;
                    player.SetActive(true);
                players.transform.position = planeTrigger.transform.position;


            }
        }
    }
}
