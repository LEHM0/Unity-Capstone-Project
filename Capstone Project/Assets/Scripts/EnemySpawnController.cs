using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    //array spawnPoints = []
    //Vector3 spawnPos

    void Start()
    {
        //Choose random spawn point (set empty GO's around map)
        //Choose enemy type based on wave count (iterate through an array for each wave)
        //Instantiate correct enemy prefab
        //elementController.CheckElement() (ToDo: Set the weakness in the prefabs instead of automatically)
        SpawnEnemy();
    }

    void Update()
    {
        //
    }

    void SpawnEnemy() //IEnumerator/Coroutine?
    {
        //spawnPos = UnityEngine.Random.Range(1, 2);
        //Select randomly from array of spawn points
    }
}
