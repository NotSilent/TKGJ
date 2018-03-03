using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LaneSwitch : MonoBehaviour
{
    [SerializeField]
    Exit[] exits;

    Exit exit;

    int exitIndex = 0;
    int exitSize;

    private void Start()
    {
        exitSize = exits.Length;
        Debug.Assert(exitSize > 0, "Exits size cannot be 0");
        exits.ToList().ForEach(exit => exit.HideExit());
        exit = exits[exitIndex];
        exit.ShowExit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            exit.HideExit();
            exitIndex = (exitIndex + 1) % exitSize;
            exit = exits[exitIndex];
            exit.ShowExit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Train>()?.ChangeTarget(exit.GetExitPosition());
    }
}
