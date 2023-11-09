using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform; // Reference to the player transform
    [SerializeField] private Transform _enemyParent; // The parent transform that the enemy will be instantiated after

    [SerializeField] private GameObject _enemyPrefab; // Reference to the enemy prefab

    [SerializeField] private Transform[] _spawnPoints; // Array of spawn point transforms

    [SerializeField] private float _spawnRate = 5.0f; // Time between enemy spawns
    [SerializeField] private int _maxEnemies = 4; // Maximum number of enemies
    [SerializeField] private float _attackRange = 1.5f; // Enemy attack range

    private List<GameObject> _enemies; // List to track active enemies

    void Start()
    {
        //_enemies = new List<GameObject>();
        //StartCoroutine(SpawnEnemies());
    }

    void Update()
    {
        ////Manage and update the list of enemies
        //UpdateEnemyList();
    }

    //IEnumerator SpawnEnemies()
    //{
    //    while (true)
    //    {
    //        if (_enemies.Count < _maxEnemies)
    //        {
    //            SpawnEnemy();
    //        }

    //        yield return new WaitForSeconds(_spawnRate);
    //    }
    //}

    //void SpawnEnemy()
    //{
    //    if (_enemyPrefab != null && _spawnPoints.Length > 0)
    //    {
    //        Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
    //        GameObject newEnemy = Instantiate(_enemyPrefab, spawnPoint.position, spawnPoint.rotation);

    ////         Set the enemies empty as the parent
    //        newEnemy.transform.parent = _enemyParent;

    ////         Attach the Enemy script to the spawned enemy (if not already attached)
    //        Enemy enemyScript = newEnemy.GetComponent<Enemy>();
    //        if (enemyScript == null)
    //        {
    //            enemyScript = newEnemy.AddComponent<Enemy>();
    //        }

    ////         Set any initial parameters for the enemy
    //        enemyScript.Initialize(_playerTransform, _attackRange);

    //        _enemies.Add(newEnemy);
    //    }
    //}

    //void UpdateEnemyList()
    //{
    //    for (int i = _enemies.Count - 1; i >= 0; i--)
    //    {
    //        if (_enemies[i] == null || !_enemies[i].activeSelf)
    //        {
    //            _enemies.RemoveAt(i);
    //        }
    //    }
    //}
}

