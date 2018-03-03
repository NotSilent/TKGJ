using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;

    Rigidbody rb;

    Vector3 targetPosition;

    [SerializeField]
    Destination[] destinations;

    TrainSpawner trainSpawner;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        targetPosition = transform.forward * 9999f;
    }

    private void Start()
    {
        trainSpawner = FindObjectOfType<TrainSpawner>();
    }

    private void FixedUpdate()
    {
        RotateInTargetDirection();
        MoveForward();
    }

    public void ChangeTarget(Vector3 targetPosition)
    {
        Vector3 direction = targetPosition - transform.forward;
        this.targetPosition = transform.position + direction * 5000f;
    }

    public Destination[] GetDestinations()
    {
        return destinations;
    }

    public void Destroy()
    {
        trainSpawner.RequestNextTrain();

        Destroy(gameObject);
    }

    private void RotateInTargetDirection()
    {
        targetPosition.y = transform.position.y;

        Vector3 direction = targetPosition - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 0.02f);
    }

    private void MoveForward()
    {
        rb.velocity = transform.forward * speed;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, targetPosition);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * 500f);
    }
}
