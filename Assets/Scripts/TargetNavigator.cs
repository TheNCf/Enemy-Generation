using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetNavigator : MonoBehaviour
{
    [SerializeField] private TargetMover _targetMover;
    [SerializeField] private List<Transform> _points;

    private int _currentPointIndex = 0;
    private float _nearDistance = 0.1f;

    private void Start()
    {
        _targetMover.SetDestination(_points[_currentPointIndex].position);
    }

    private void Update()
    {
        Work();
    }

    private void Work()
    {
        float sqrDistance = (_points[_currentPointIndex].position - _targetMover.transform.position).sqrMagnitude;

        if (sqrDistance < _nearDistance)
        {
            _currentPointIndex = ++_currentPointIndex % _points.Count;
            _targetMover.SetDestination(_points[_currentPointIndex].position);
        }
    }
}
