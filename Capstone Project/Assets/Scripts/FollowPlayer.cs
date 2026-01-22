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

            transform.eulerAngles += new Vector3(rotationY, rotationX);
        }
        
        if (gameController.isGameActive == false)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
