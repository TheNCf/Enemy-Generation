using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed = 4.0f;

    private CharacterController _characterController;

    private Transform _target;

    public void Initialize(Transform target)
    {
        _target = target;
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
        if (_target == null)
            return;

        Vector3 direction = (_target.position - transform.position).normalized;

        _characterController.Move(direction * _speed * Time.deltaTime);
        transform.forward = direction;
    }
}
