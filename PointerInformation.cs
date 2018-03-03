using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerInformation : MonoBehaviour
{
    public RaycastHit GetRaycastInfo()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f)), out hit, 100f, LayerMask.NameToLayer("Race")))
        {

        }
        return hit;
    }
}
