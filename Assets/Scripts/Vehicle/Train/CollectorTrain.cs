using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TrainStash))]
public class CollectorTrain : MonoBehaviour
{
    private TrainStash _stash;

    private void Awake()
    {
        _stash = GetComponent<TrainStash>();
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Buradayim");
       
            if (other.TryGetComponent(out Collectable collected))
            {
               
                _stash.AddStash(collected);
            }
        
    }
   
}
