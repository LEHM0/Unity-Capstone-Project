using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementController : MonoBehaviour
{
    public string weakness;
    private EnemyController enemyController;

    void Start()
    {
        enemyController = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyController>();
    }

    void Update()
    {
        //
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

    void OnSpawn()
    {
        CheckElement();
    } //Redundant?

    public void ApplyWeakness(string checkedElement)
    {
        if (checkedElement == weakness)
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
