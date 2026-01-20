using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        //
    }

    void Update()
    {
        //Move the camera in front of where the player moves and wants to face
        transform.position = player.transform.position;
        transform.rotation = player.transform.rotation;
    }
}
