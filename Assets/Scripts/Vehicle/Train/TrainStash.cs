using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainStash : MonoBehaviour
{
    public Transform stashParent;
    public List<Stashable> CollectedObjects = new List<Stashable>();
    

    public int CollectedCount => CollectedObjects.Count;
    public float collectionHeight = 1;
    public int maxCollectableCount=20;
  

    public void AddStash(Collectable collectedObject)
    {
        
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
}
