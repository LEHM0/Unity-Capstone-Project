using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private GameController gameController;

    //Main Stats
    public int maxHealth = 12;
    public int currentHealth;
    public bool isDead = false;
    public int totalPoints = 0;

    //Gun + Ammo Stats
    public int playerAttack = 1;
    public int unlockedAttacks; // Controls what attacks the player can use; 0 = Basic, 6 = All Attacks Available
    public int selectedAttack;
    public string attackType;
    public int leftGunMaxAmmo = 6;
    public int leftGunCurrentAmmo;
    public int rightGunMaxAmmo = 6;
    public int rightGunCurrentAmmo;
    public bool leftGunReloading = false;
    public bool rightGunReloading = false;

    void Start()
    {
        gameController = GameObject.Find("Game Manager").GetComponent<GameController>();

        //Set all stats to correct values at start of game
        currentHealth = maxHealth;
        totalPoints = 0;

        selectedAttack = 0;
        attackType = "Basic";
        leftGunCurrentAmmo = leftGunMaxAmmo;
        rightGunCurrentAmmo = rightGunMaxAmmo;
    }

    void Update()
    {
        PlayerAttackTypes();

        //Check for when the player dies
        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }

        if (currentHealth == 0)
        {
            Dead();
        }
    }

    private void PlayerAttackTypes()
    {
        //selectedAttack = 0 (Basic)
        if (selectedAttack == 0)
        {
            attackType = "Basic";
        }
        //selectedAttack = 1 (Fire)
        if (selectedAttack == 1)
        {
            attackType = "Fire";
        }
        //selectedAttack = 2 (Ice)
        if (selectedAttack == 2)
        {
            attackType = "Ice";
        }
        //selectedAttack = 3 (Earth)
        if (selectedAttack == 3)
        {
            attackType = "Earth";
        }
        //selectedAttack = 4 (Wind)
        if (selectedAttack == 4)
        {
            attackType = "Wind";
        }
        //selectedAttack = 5 (Light)
        if (selectedAttack == 5)
        {
            attackType = "Light";
        }
        //selectedAttack = 6 (Dark)
        if (selectedAttack == 6)
        {
            attackType = "Dark";
        }
    }

    private void Dead()
    {
        //Flags the player as dead, ending the game
        isDead = true;

        if (isDead == true)
        {
            gameController.GameOver();
        }
    }
}
