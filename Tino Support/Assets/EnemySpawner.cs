using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnInterval = 0f;
    public GameObject enemy;
    public GameObject player;
    
    private float _timer = 0f;

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > spawnInterval)
        {
            SpawnEnemy();
            _timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        var newEnemy = Instantiate(enemy);
        newEnemy.GetComponent<EnemyMovement>().player = player;
    }
}
