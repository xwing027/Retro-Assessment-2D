using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject ghost1;
    //public GameObject ghost2;
    //public GameObject ghost3;
    public Transform pointA;
    public Transform pointB;
    //public Transform pointC;
    //public Transform pointD;
    Vector2 spawnPos;

    void Start()
    {
        InvokeRepeating("Ghost1Spawn", .2f,.2f);
        //InvokeRepeating("Ghost2Spawn", 3f, .7f);
        //InvokeRepeating("Ghost3Spawn", 5f, .7f);
    }

    void Ghost1Spawn()
    {
        spawnPos = Vector2.Lerp(pointA.position, pointB.position, Random.Range(0f, 1f));
        Instantiate(ghost1, spawnPos, Quaternion.identity);
    }
    /*
    void Ghost2Spawn()
    {
        spawnPos = Vector2.Lerp(pointA.position, pointB.position, Random.Range(0f, 1f));
        Instantiate(ghost2, spawnPos, Quaternion.identity);
    }

    void Ghost3Spawn()
    {
        spawnPos = Vector2.Lerp(pointC.position, pointD.position, 0f);
        Instantiate(ghost3, spawnPos, Quaternion.identity);
    }*/
}
