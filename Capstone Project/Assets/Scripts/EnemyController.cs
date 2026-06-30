using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject self;
    public GameObject enemyProjectile;
    public GameObject enemyBSpawn;
    private Rigidbody enemyRb;
    private PlayerStats playerStats;
    private GameController gameController;

    private Vector3 playerPos;
    private Vector3 currentPos;
    private Vector3 follow;

    [Header("Stats")]
    public string elementType = "Basic";
    public string weakness = "Null";
    public float speed = 2.0f;
    public int health = 10;
    public int incomingDmgMult;
    public int enemyAttack = 1;
    public float fireRate = 5.0f;
    public float fireCooldown = 0.0f;
    public int points = 10;
    public bool playerInRange;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
        gameController = GameObject.Find("Game Manager").GetComponent<GameController>();

        StartCoroutine(FireAtPlayer());
    }

    void Update()
    {
        playerPos = GameObject.Find("Player").transform.position;

        if (gameController.isGameActive == true)
        {
            FollowPlayer();
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

    public void ApplyWeakness(string checkedElement)
    {
        if (checkedElement == weakness)
        {
            incomingDmgMult = 2;
        }
        else
        {
            incomingDmgMult = 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player Projectile"))
        {
            //Compare the element of the incoming attack to the enemy's weakness
            AttachElement attachElement = other.gameObject.GetComponent<AttachElement>();
            string incomingElement = attachElement.attachedElement;
            ApplyWeakness(incomingElement);

            //Apply damage value
            health -= playerStats.playerAttack * incomingDmgMult;
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
        if (playerInRange) return;
        follow = (playerPos - transform.position).normalized;
        transform.Translate(follow * speed * Time.deltaTime);
    }

    IEnumerator FireAtPlayer()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);

            if (gameController.isGameActive && playerInRange)
            {
                fireCooldown += 0.1f;
                if (fireCooldown >= fireRate)
                {
                    currentPos = enemyBSpawn.transform.position;
                    Instantiate(enemyProjectile, currentPos, self.transform.rotation);
                    fireCooldown = 0f;
                }
            }
        }
    }
}
