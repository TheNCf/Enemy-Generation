using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] public EnemyMover _enemyPrefab;
    [SerializeField] public Transform _targetTransform;

    public void Spawn()
    {
        EnemyMover enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        enemy.Initialize(_targetTransform);
    }
}
