using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public float speed;

    void Update()
    {
        float yTarget = target.position.y+3; //find the target on the y axis
        float yPos = Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * speed); //use the target's y axis to add a delay to the movement
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z); //move the camera w the target's position
    }
}
