using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMover : MonoBehaviour
{
    public float speed;
    float currentSpeed;
    public GameObject player;
    float distance;

    private void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position); //getting the distance from the player
        
        if (distance <= 5)
        {
            GhostMove();
        }
    }

    void GhostMove()
    {
        transform.position = player.transform.position * speed * Time.deltaTime;
    }
}
