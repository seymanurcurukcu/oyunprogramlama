using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AracInme : MonoBehaviour
{


    public List<GameObject> araclar = new List<GameObject>();
    public GameObject exitplane;
    public GameObject players;
  

    public bool onClick = true;
    public void ExitSystem()
    {
        onClick = true;
    }
    private void Update()
    {
        
        
       
        if (onClick==true)
        {
            
                onClick = false;
            araclar.ForEach((x) => x.SetActive(false));
            players.transform.position = exitplane.transform.position;


        }
    }




}
