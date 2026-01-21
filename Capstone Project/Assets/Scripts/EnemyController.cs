using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public Transform playerTransform;
    public GameObject self;
    public GameObject enemyProjectile;
    public GameObject enemyBSpawn;
    private Rigidbody enemyRb;
    private PlayerStats playerStats;
    private GameController gameController;

    private Vector3 playerPos;
    private Vector3 currentPos;
    //private Vector3 offset = new Vector3(0, 0, 1);
    private Vector3 follow;
    //private Vector3 aim;

    private float speed = 2.0f;
    //private float turnSpeed = 20.0f;
    public int health = 10;
    public int enemyAttack = 1;
    private float fireRate = 5.0f;
    public float fireCooldown = 0.0f;
    private int points = 10;
    public bool playerInRange;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
        gameController = GameObject.Find("Game Manager").GetComponent<GameController>();
    }

    void Update()
    {
        playerPos = player.transform.position;

        if (gameController.isGameActive == true)
        {
            //
            transform.LookAt(playerTransform);

            //FollowPlayer();

            StartCoroutine(FireAtPlayer());
        }

        if (Vector3.Distance(playerPos, transform.position) <= 5)
        {
            playerInRange = true;
        }
        if (Vector3.Distance(playerPos, transform.position) >= 5)
        {
            playerInRange = false;
            fireCooldown = 0.0f;
        }

        if (health <= 0)
        {
            Death();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player Projectile"))
        {
            health -= playerStats.playerAttack;
            Destroy(other.gameObject);
            Debug.Log("Enemy Hit");
        }
    }

    private void Death()
    {
        Destroy(gameObject);
        Debug.Log("Enemy Died");

        playerStats.totalPoints += points;
        Debug.Log("Total Points is now: " + playerStats.totalPoints);
    }

    private void FollowPlayer()
    {
        //
        follow = (playerPos - transform.position).normalized;
        transform.Translate(follow * speed * Time.deltaTime);
    }

    IEnumerator FireAtPlayer()
    {
        yield return new WaitForSeconds(1);
        if (playerInRange == true)
        {
            fireCooldown += Time.deltaTime;
            if (fireCooldown > fireRate)
            {
                currentPos = enemyBSpawn.transform.position;

                Instantiate(enemyProjectile, currentPos, self.transform.rotation);

                fireCooldown = fireCooldown - fireRate;
            }
        }
    }
}
