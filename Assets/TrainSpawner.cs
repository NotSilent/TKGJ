using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject startingPosition;

    [SerializeField]
    GameObject trainPrefab;

    public void RequestNextTrain()
    {
        Instantiate(trainPrefab, startingPosition.transform.position, Quaternion.identity);
    }
}
