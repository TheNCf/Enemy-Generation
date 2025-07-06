using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed = 4.0f;

    private CharacterController _characterController;

    private Vector3 _direction;

    public void Initialize(Vector3 direction)
    {
        transform.forward = direction;
        _direction = direction;
    }

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _characterController.Move(_direction * _speed * Time.deltaTime);
    }
}
