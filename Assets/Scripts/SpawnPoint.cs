using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemyPrefab;
    [SerializeField] private Transform _targetTransform;

    public void Spawn()
    {
        EnemyMover enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        enemy.Initialize(_targetTransform);
    }
}
