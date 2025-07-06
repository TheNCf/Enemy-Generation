using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemyPrefab;
    [Space(10)]
    [SerializeField] private List<SpawnPoint> _spawnPoints = new();
    [SerializeField] private float _spawnDelay = 2.0f;

    private void Awake()
    {
        if (_spawnPoints.Count == 0)
            enabled = false;

        StartCoroutine(SpawnCoroutine());
    }

    private IEnumerator SpawnCoroutine()
    {
        while (_spawnPoints.Count > 0)
        {
            yield return new WaitForSeconds(_spawnDelay);

            int randomIndex = Random.Range(0, _spawnPoints.Count);
            SpawnPoint spawnPoint = _spawnPoints[randomIndex];

            if (spawnPoint == null)
                continue;

            spawnPoint.Spawn();
        }
    }
}
