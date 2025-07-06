using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemyPrefab;
    [Space(10)]
    [SerializeField] private List<Transform> _spawnPoints = new();
    [SerializeField] private float _spawnDelay = 2.0f;

    private void Awake()
    {
        if (_spawnPoints.Count == 0)
            enabled = false;

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (_spawnPoints.Count > 0)
        {
            yield return new WaitForSeconds(_spawnDelay);

            int randomIndex = Random.Range(0, _spawnPoints.Count);
            Transform spawnPointTransform = _spawnPoints[randomIndex];

            if (spawnPointTransform == null)
                continue;

            EnemyMover enemy = Instantiate(_enemyPrefab, spawnPointTransform.position, Quaternion.identity);
            enemy.Initialize(spawnPointTransform.forward);
        }
    }
}
