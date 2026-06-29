using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    public GameObject basicE; //0
    public GameObject fireE;  //1
    public GameObject iceE;   //2
    public GameObject earthE; //3
    public GameObject windE;  //4
    public GameObject lightE; //5
    public GameObject darkE;  //6

    private int[,] waves = { {1 }, {2 }, {3 }, {4 }, {5 }, {6 }, {7 }, {8 }, {9 }, {10 } }; //0-9

    void Start()
    {
        //Array of enemy prefabs for each wave
        //Method to control the wave start, spawn cooldown, correct enemy array, wave end, and downtime
        //Merge w/ GameController or EnemySpawnController?

        //if waveCount = i
        //x = i
        //foreach n in waves[x]
        //y = n
        //spawn enemy type based on x,y at [random spawn point]
    }

    void Update()
    {
        //
    }
}
