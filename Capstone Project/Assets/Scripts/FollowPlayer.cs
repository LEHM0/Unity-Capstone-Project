using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private GameController gameController;

    public float sensitivityY = 1f;
    public float sensitivityX = 1f;
    float rotationY = 1f;
    float rotationX = 1f;

    void Start()
    {
        gameController = GameObject.Find("Game Manager").GetComponent<GameController>();
    }

    void Update()
    {
        if (gameController.isGameActive == true)
        {
            //Move the camera in front of where the player moves and wants to face
            Cursor.lockState = CursorLockMode.Locked;
            transform.position = player.transform.position;
            rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
            rotationX = Input.GetAxis("Mouse X") * sensitivityX;

            rotationX = Mathf.Clamp(rotationX, -89f, 89f);

            //transform.rotation = Quaternion.Euler(rotationX, rotationY, 0f);

            transform.eulerAngles += new Vector3(-rotationY, rotationX);

            //rotationX += -Input.GetAxis("Mouse Y") * sensitivityX;
            //rotationX = Mathf.Clamp(rotationX, -89f, 89f);
            //playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            //transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
        }

        if (gameController.isGameActive == false)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
