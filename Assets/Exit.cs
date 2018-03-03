using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    [SerializeField]
    GameObject exitPosition;
    [SerializeField]
    GameObject destinationObjectPrefab;

    GameObject destinationObject;

    Material defaultMaterial;
    Color defaultColor;
    
    public Vector3 GetExitPosition()
    {
        return exitPosition.transform.position;
    }

    private void Awake()
    {
        defaultMaterial = GetComponent<MeshRenderer>()?.material;
        defaultColor = defaultMaterial.GetColor("_Color");

        destinationObject = Instantiate(destinationObjectPrefab, exitPosition.transform.position, Quaternion.identity);
    }

    public void ShowExit()
    {
        defaultMaterial.SetColor("_Color", Color.magenta);
    }

    public void HideExit()
    {
        defaultMaterial.SetColor("_Color", defaultColor);
    }
}
