using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stash : MonoBehaviour
{
    public Transform stashParent;
    public List<Stashable> CollectedObjects = new List<Stashable>();
    public List<GameObject> araclar = new List<GameObject>();

    public int CollectedCount => CollectedObjects.Count;
    public float collectionHeight = 1;
    public int maxCollectableCount;
   
    // Start is called before the first frame update
    void Start()
    {
        maxCollectableCount = 5;
      


    }

    public void AddStash(Collectable collectedObject)
    {
        foreach (var item in araclar)
        {
            if (item.activeSelf)
            {
               
               
                if (item.ToString() == "Car (UnityEngine.GameObject)")
                {
                    
                    maxCollectableCount = 10;

                }
               else if (item.ToString() == "Yacht (UnityEngine.GameObject)")
                {
                  
                    maxCollectableCount = 15;

                }
               else if (item.ToString() == "Aircraft (UnityEngine.GameObject)")
                {

                    maxCollectableCount = 20;

                }
            }
           


        }
        if (CollectedCount >= maxCollectableCount)
            return;

        var yLocalPosition = CollectedCount * collectionHeight;

        var stashable = collectedObject.Collect();
       
        stashable.CollectStashable(stashParent, yLocalPosition, CompleteCollection);
        Debug.Log(stashParent);
        CollectedObjects.Add(stashable);
         
    }

    private void CompleteCollection()
    {


    }

    public Stashable RemoveStash()
    {
        if (CollectedCount <= 0)
            return null;

        var stashable = CollectedObjects[CollectedCount - 1];

        CollectedObjects.Remove(stashable);
        stashable.transform.parent = null;

        return stashable;

    }
}
