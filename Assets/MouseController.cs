using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    PointerInformation pointerInformation;
    Action onMousePressed;

    public void Subscribe(Action onMousePressed)
    {
        this.onMousePressed += onMousePressed;
    }

    public void Unsubscribe(Action onMousePressed)
    {
        this.onMousePressed -= onMousePressed;
    }

    private void Start()
    {
        pointerInformation = GetComponent<PointerInformation>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onMousePressed();
        }
    }

    private void OnEnable()
    {
        onMousePressed += () => Point();
    }

    private void Point()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100f, 1 << LayerMask.NameToLayer("Race")))
        {
            Fire(hit.collider.gameObject);
        }
    }

    private void Fire(GameObject gameObject)
    {
        Destroy(gameObject);
    }
}
