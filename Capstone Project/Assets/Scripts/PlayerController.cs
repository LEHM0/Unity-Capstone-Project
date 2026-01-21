using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //All components and scripts referenced
    public GameObject player;
    public GameObject playerProjectile;
    public GameObject playerBSpawn;
    private Rigidbody playerRb;
    private PlayerStats playerStats;
    private EnemyController enemyController;
    private GameController gameController;

    //Vector3's for determining bullet position
    private Vector3 currentPlayerPos;
    //private Vector3 bulletSpawnPos;
    //private Vector3 bulletOffSet = new Vector3(0, 0, 1);

    //Movement variables
    private float verticalInput;
    private float horizontalInput;
    private float speed = 10;
    //private float turnSpeed = 20;
    private float jump = 10;
    private bool grounded = true;

    void Start()
    {
        //Call rigidbody and neccessary scripts
        playerRb = GetComponent<Rigidbody>();
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
        enemyController = GameObject.Find("Basic Enemy").GetComponent<EnemyController>();
        gameController = GameObject.Find("Game Manager").GetComponent<GameController>();
    }

    void Update()
    {
        //Movement Input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Movement Physics
        if (gameController.isGameActive == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }

        //Jumping Physics
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            if (gameController.isGameActive == true)
            {
                playerRb.AddForce(Vector3.up * jump, ForceMode.Impulse);
                grounded = false;
            }
            //playerRb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            //grounded = false;
        }

        //Use the Mouse Wheel to select Attacks
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            playerStats.selectedAttack++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            playerStats.selectedAttack--;
        }
        if (playerStats.selectedAttack > 6)
        {
            playerStats.selectedAttack = 0;
        }
        if (playerStats.selectedAttack < 0)
        {
            playerStats.selectedAttack = 6;
        }

        //Left Gun Firing and Reloading
        if (Input.GetKeyDown(KeyCode.Mouse0) && playerStats.leftGunCurrentAmmo != 0)
        {
            if (gameController.isGameActive == true)
            {
                FireProjectile();
                playerStats.leftGunCurrentAmmo -= 1;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && playerStats.leftGunCurrentAmmo == 0)
        {
            Debug.Log("Left Gun Out Of Ammo: Reloading");
            StartCoroutine(LGReload());
        }

        //Right Gun Firing and Reloading
        if (Input.GetKeyDown(KeyCode.Mouse1) && playerStats.rightGunCurrentAmmo != 0)
        {
            if (gameController.isGameActive == true)
            {
                FireProjectile();
                playerStats.rightGunCurrentAmmo -= 1;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1) && playerStats.rightGunCurrentAmmo == 0)
        {
            Debug.Log("Right Gun Out Of Ammo: Reloading");
            StartCoroutine(RGReload());
        }

        //Manual Reload
        if (Input.GetKeyDown(KeyCode.R))
        {
            CheckReload();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Cannot jump while in air
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }

        //Take damage when colliding with enemy or projectile
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            playerStats.currentHealth -= enemyController.enemyAttack;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy Projectile"))
        {
            playerStats.currentHealth -= enemyController.enemyAttack;
            Destroy(other.gameObject);
        }
    }

    private void FireProjectile()
    {
        //Spawn projectile in front of where the player is facing
        currentPlayerPos = playerBSpawn.transform.position;

        Instantiate(playerProjectile, currentPlayerPos, player.transform.rotation);
    }

    private void CheckReload()
    {
        //Check which guns need to be manually reloaded
        if (playerStats.leftGunCurrentAmmo != playerStats.leftGunMaxAmmo)
        {
            StartCoroutine(LGReload());
        }
        else
        {
            Debug.Log("Left Gun Ammo Full");
        }

        if (playerStats.rightGunCurrentAmmo != playerStats.rightGunMaxAmmo)
        {
            StartCoroutine(RGReload());
        }
        else
        {
            Debug.Log("Right Gun Ammo Full");
        }
    }

    IEnumerator LGReload()
    {
        //Reload the Left Gun
        Debug.Log("Left Gun Now Reloading");
        playerStats.leftGunReloading = true;
        //yield return new WaitForSeconds(playerStats.reloadTime);
        yield return new WaitForSeconds(2);
        playerStats.leftGunCurrentAmmo = playerStats.leftGunMaxAmmo;
        playerStats.leftGunReloading = false;
        Debug.Log("Left Gun Reloaded");
    }

    IEnumerator RGReload()
    {
        //Reload the Right Gun
        Debug.Log("Right Gun Now Reloading");
        playerStats.rightGunReloading = true;
        //yield return new WaitForSeconds(playerStats.reloadTime);
        yield return new WaitForSeconds(2);
        playerStats.rightGunCurrentAmmo = playerStats.rightGunMaxAmmo;
        playerStats.rightGunReloading = false;
        Debug.Log("Right Gun Reloaded");
    }
}
