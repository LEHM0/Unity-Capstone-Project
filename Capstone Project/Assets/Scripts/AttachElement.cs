using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachElement : MonoBehaviour
{
    public string attachedElement;

    private PlayerStats playerStats;

    void Awake()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();

        SetElement(playerStats.attackType);
    }

    void Update()
    {
        //
    }

    public void SetElement(string element)
    {
        attachedElement = element;
    }
}
