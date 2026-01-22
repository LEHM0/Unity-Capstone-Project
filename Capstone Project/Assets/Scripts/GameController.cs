using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool isGameActive = false;
    private int waveNum = 0;
    private float waveDownTime;
    private int maxEnemies;
    private int currentEnemies = 0;

    private PlayerStats playerStats;

    [Header("Menu UI")]
    public GameObject mainMenu;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    //Add extra menu for repeat buttons?

    [Header("Buttons")]
    public Button startButton;
    public Button waveSelectButton;
    public Button restartButton;
    public Button exitMenuButton;
    public Button exitGameButton;

    [Header("Player UI")]
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
        TitleScreen();

        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();

        //Button Listeners
        startButton.onClick.AddListener(StartGame);
        //waveSelectButton.onClick.AddListener();
        //restartButton.onClick.AddListener(RestartGame);
        //exitMenuButton.onClick.AddListener(TitleScreen); <---
        //exitGameButton.onClick.AddListener();
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
        isGameActive = false;

        mainMenu.SetActive(true);
        pauseMenu.SetActive(false);
        gameOverMenu.SetActive(false);
        playerUI.SetActive(false);
    }

    public void StartGame()
    {
        isGameActive = true;

        mainMenu.SetActive(false);
        pauseMenu.SetActive(false);
        gameOverMenu.SetActive(false);
        playerUI.SetActive(true);
    }

    public void PauseGame()
    {
        isGameActive = false;

        mainMenu.SetActive(false);
        pauseMenu.SetActive(true);
        gameOverMenu.SetActive(false);
        playerUI.SetActive(false);
    }

    public void RestartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        isGameActive = false;

        mainMenu.SetActive(false);
        pauseMenu.SetActive(false);
        gameOverMenu.SetActive(true);
        playerUI.SetActive(false);
    }
}
