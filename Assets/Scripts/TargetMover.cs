using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private float _smoothTime = 1f;

    private Vector3 _destination;
    private Vector3 _velocity;

    public void SetDestination(Vector3 destination)
    {
        _destination = destination;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.SmoothDamp(transform.position, _destination, ref _velocity, _smoothTime);
    }
}
