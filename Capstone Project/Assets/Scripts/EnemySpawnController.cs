using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    private WaveController waveController;

    public Transform[] spawnPoints;
    private float spawnCooldown = 1.5f;
    private float spawnTimer = 0f;

    private void Start()
    {
        waveController = GameObject.Find("Enemy Spawn Manager").GetComponent<WaveController>();
    }

    void Update()
    {
        waveController.NextEnemy();
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        if (waveController.upcomingEnemies.Count == 0) return;

        spawnTimer += Time.deltaTime;
        if (spawnTimer < spawnCooldown) return;

        spawnTimer = 0f;

        GameObject enemyToSpawn = waveController.upcomingEnemies[0];
        waveController.upcomingEnemies.RemoveAt(0);

        Transform spawnPoint = spawnPoints[UnityEngine.Random.Range(0, spawnPoints.Length)];
        Instantiate(enemyToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}
