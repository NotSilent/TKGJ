using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Race : MonoBehaviour
{
    [SerializeField]
    string race;

    [SerializeField]
    Destination[] destinations;

    public Destination[] GetDestinations()
    {
        return destinations;
    }
}
