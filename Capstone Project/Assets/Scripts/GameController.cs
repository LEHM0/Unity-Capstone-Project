using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool isGameActive;
    private int waveNum = 0;
    private float waveDownTime;
    private int maxEnemies;
    private int currentEnemies = 0;

    private PlayerStats playerStats;

    public GameObject mainMenu;
    public GameObject gameOverMenu;

    public GameObject playerUI;
    public TextMeshProUGUI playerHealthUI;
    public TextMeshProUGUI playerAttackUI;
    public TextMeshProUGUI playerPointsUI;
    public TextMeshProUGUI leftGunAmmoUI;
    public TextMeshProUGUI rightGunAmmoUI;
    public TextMeshProUGUI waveNumUI;
    public TextMeshProUGUI enemiesLeftUI;

    void Start()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
    }

    void Update()
    {
        playerHealthUI.SetText(playerStats.currentHealth.ToString());
        playerAttackUI.SetText(playerStats.selectedAttack.ToString());
        playerPointsUI.SetText(playerStats.totalPoints.ToString());

        leftGunAmmoUI.SetText(playerStats.leftGunCurrentAmmo.ToString());
        if (playerStats.leftGunReloading == true)
        {
            leftGunAmmoUI.SetText("Reloading");
        }
        rightGunAmmoUI.SetText(playerStats.rightGunCurrentAmmo.ToString());
        if (playerStats.rightGunReloading == true)
        {
            rightGunAmmoUI.SetText("Reloading");
        }

        waveNumUI.SetText(waveNum.ToString());
        enemiesLeftUI.SetText(currentEnemies.ToString());
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //gameOverMenu.SetActive(false);
    }

    public void StartGame()
    {
        isGameActive = true;
        mainMenu.SetActive(false);
        playerUI.SetActive(true);
    }

    public void RestartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        isGameActive = false;
        playerUI.SetActive(false);
        gameOverMenu.SetActive(true);
    }
}
