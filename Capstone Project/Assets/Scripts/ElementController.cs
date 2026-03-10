using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementController : MonoBehaviour
{
    public string weakness;

    private EnemyController enemyController;
    //private AttachElement AttachElement;
    private PlayerStats playerStats;

    void Start()
    {
        enemyController = GameObject.Find("Basic Enemy").GetComponent<EnemyController>();
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
    }

    void Update()
    {
        CheckElement();
        ApplyWeakness();
    }

    void CheckElement()
    {
        switch (enemyController.elementType)
        {
            case "Basic":
                weakness = "Null";

                break;
            case "Fire":
                weakness = "Ice";

                break;
            case "Ice":
                weakness = "Fire";

                break;
            case "Earth":
                weakness = "Wind";

                break;
            case "Wind":
                weakness = "Earth";

                break;
            case "Light":
                weakness = "Dark";

                break;
            case "Dark":
                weakness = "Light";

                break;
        }
    }

    void ApplyWeakness()
    {
        if (playerStats.attackType == weakness) //Set to check the bullet's attack type
        {
            enemyController.incomingDmgMult = 2;
        }
        else
        {
            enemyController.incomingDmgMult = 1;
        }
    }

    void ApplyResistance()
    {
        //
    }

    void ApplyNullificaion()
    {
        //
    }
}
