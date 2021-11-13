using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMover : MonoBehaviour
{
    public float speed;

    //find the distance to the player
    //move towards the player once within range
    //if touch the player kill them

    void Chase(GameObject player, float currentSpeed) //not in use for the assessment
    {
        float distance = Vector2.Distance(transform.position, player.transform.position); //getting the distance from the player

        //this finds the direction to the goal
        Vector2 direction = (player.transform.position - transform.position).normalized;
        Vector2 position = transform.position;

        // this movies the ai towards the direction set (aka the goal)
        position += (direction * currentSpeed * Time.deltaTime);
        transform.position = position;

        if (distance < speed * Time.deltaTime)
        {
            player.SetActive(false); //this 'kills' the player when the AI catches up to it
        }
    }
}
