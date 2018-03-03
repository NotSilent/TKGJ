using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Destination", menuName = "TKGJ/Destination")]
public class Destination : ScriptableObject
{
    [SerializeField]
    //Race[] allowedRaces;

    public static bool Match(Destination lhs, Destination rhs)
    {
        return lhs.name == rhs.name;
    }
}
