using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WaveController : MonoBehaviour //Future: Merge w/ EnemySpawnController?
{
    private GameController gameController;

    public int enemyIndex = 0;
    public bool onCooldown = false;

    public int waveNum = 0; //1-10
    private float waveDownTime = 10.0f;
    private int maxEnemies = 5;
    public int currentEnemies = 0;

    public GameObject basicE; //1
    public GameObject fireE;  //2
    public GameObject iceE;   //3
    public GameObject earthE; //4
    public GameObject windE;  //5
    public GameObject lightE; //6
    public GameObject darkE;  //7

    private int[,] waves = { 
        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
        { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 }, 
        { 2, 3, 2, 3, 2, 3, 2, 3 ,2, 3 }, 
        { 3, 4, 3, 4, 3, 4, 3, 4, 3, 4 }, 
        { 4, 5, 4, 5, 4, 5, 4, 5, 4, 5 }, 
        { 5, 6, 5, 6, 5, 6, 5, 6, 5, 6 }, 
        { 6, 7, 6, 7, 6, 7, 6, 7, 6, 7 }, 
        { 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 }, 
        { 2, 3, 4, 2, 3, 4, 5, 4, 3, 2 }, 
        { 2, 3, 4, 5, 6 ,7, 5, 6, 7, 6 } }; //0-9

    public List<GameObject> upcomingEnemies = new List<GameObject>();

    void Start()
    {
        gameController = GameObject.Find("Game Manager").GetComponent<GameController>();
    }

    void Update()
    {
        CountEnemies();
        NextEnemy();
    }

    void CountEnemies()
    {
        currentEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    GameObject GetEnemyPrefab(int id)
    {
        GameObject prefab = id switch
        {
            1 => basicE,
            2 => fireE,
            3 => iceE,
            4 => earthE,
            5 => windE,
            6 => lightE,
            7 => darkE,
            _ => null
        };

        if (prefab == null)
            Debug.LogWarning($"Enemy prefab for id {id} is unassigned or unknown.");

        return prefab;
    }

    public void NextEnemy()
    {
        if (onCooldown || !gameController.isGameActive) return;

        while (currentEnemies + upcomingEnemies.Count < maxEnemies)
        {
            if (enemyIndex >= waves.GetLength(1))
            {
                StartCoroutine(WaveCooldown());
                break;
            }

            int enemyId = waves[waveNum, enemyIndex];
            GameObject prefab = GetEnemyPrefab(enemyId);

            if (prefab != null)
                upcomingEnemies.Add(prefab);

            enemyIndex++;
        }
    }

    IEnumerator WaveCooldown()
    {
        onCooldown = true;
        yield return new WaitForSeconds(waveDownTime);

        enemyIndex = 0;
        waveNum++;
        onCooldown = false;
    }
}
