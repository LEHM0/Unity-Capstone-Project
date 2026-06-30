using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private GameController gameController;

    public float sensitivityY = 1f;
    public float sensitivityX = 1f;

    private float pitch = 0f;
    private float yaw = 0f;

    void Start()
    {
        gameController = GameObject.Find("Game Manager").GetComponent<GameController>();
    }

    void Update()
    {
        if (gameController.isGameActive)
        {
            Cursor.lockState = CursorLockMode.Locked;
            transform.position = player.transform.position;

            yaw += Input.GetAxis("Mouse X") * sensitivityX;
            pitch -= Input.GetAxis("Mouse Y") * sensitivityY;
            pitch = Mathf.Clamp(pitch, -89f, 89f);

            transform.eulerAngles = new Vector3(pitch, yaw, 0f);
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
