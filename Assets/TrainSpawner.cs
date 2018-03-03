using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrainSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject startingPosition;

    [SerializeField]
    GameObject trainPrefab;

    [SerializeField]
    Race[] races;

    private void Start()
    {
        GameObject trainGO = SpawnTrain();
    }

    public void RequestNextTrain()
    {
        SpawnTrain();
    }

    GameObject SpawnTrain()
    {
        GameObject trainGO = Instantiate(trainPrefab, startingPosition.transform.position, Quaternion.identity);
        Train train = trainGO.GetComponent<Train>();
        train.Init(races.ElementAt(Random.Range(0, races.Length)));
        return trainGO;
    }
}
