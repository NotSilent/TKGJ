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
    LivesCounter livesCounter;

    private void Start()
    {
        scoreCounter = FindObjectOfType<ScoreCounter>();
        livesCounter = FindObjectOfType<LivesCounter>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Train train = other.GetComponent<Train>();

        if(train)
        {
            Race race = train.GetRace();
            Destination[] destinations = race.GetDestinations();

            bool match = destinations.ToList().Exists(destination => Destination.Match(this.destination, destination));
            if (match)
            {
                scoreCounter.Add(REWARD);
            }
            else
            {
                scoreCounter.Add(-REWARD);
                livesCounter.LoseLive();
            }

            train.Destroy();
        }
    }
}
