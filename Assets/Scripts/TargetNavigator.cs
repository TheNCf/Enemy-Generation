using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetNavigator : MonoBehaviour
{
    [SerializeField] private TargetMover _targetMover;
    [SerializeField] private Transform _startPointTransform;
    [SerializeField] private Transform _endPointTransform;

    private Transform _pointMovingToTransform;

    private void Awake()
    {
        _pointMovingToTransform = _endPointTransform;
    }

    private void Start()
    {
        _targetMover.SetDestination(_pointMovingToTransform.position);
    }

    private void Update()
    {
        Work();
    }

    private void Work()
    {
        if (Vector3.Distance(_pointMovingToTransform.position, _targetMover.transform.position) < 0.1f)
        {
            if (_pointMovingToTransform == _startPointTransform)
                _pointMovingToTransform = _endPointTransform;
            else
                _pointMovingToTransform = _startPointTransform;

            _targetMover.SetDestination(_pointMovingToTransform.position);
        }
    }
}
