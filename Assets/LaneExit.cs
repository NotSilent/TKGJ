using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LaneExit : MonoBehaviour
{
    const int REWARD = 1;

    [SerializeField]
    Destination destination;

    ScoreCounter scoreCounter;

    private void Start()
    {
        scoreCounter = FindObjectOfType<ScoreCounter>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Train train = other.GetComponent<Train>();

        if(train)
        {
            Destination [] destinations = train.GetDestinations();

            bool match = destinations.ToList().Exists(destination => Destination.Match(this.destination, destination));
            if (match)
            {
                scoreCounter.Add(REWARD);
            }
            else
            {
                scoreCounter.Add(-REWARD);
            }

            train.Destroy();
        }
    }
}
