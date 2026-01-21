using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    public float sensitivityY = 1f;
    public float sensitivityX = 1f;
    float rotationY = 1f;
    float rotationX = 1f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //Move the camera in front of where the player moves and wants to face
        transform.position = player.transform.position;
        //transform.rotation = player.transform.rotation;
        rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
        rotationX = Input.GetAxis("Mouse X") * sensitivityX;

        transform.eulerAngles += new Vector3(rotationY, rotationX);
    }
}
