using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public float speed;
    void Update()
    {
        //move - so far this handles all obstacles the same way
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        //destroy themselves eventually
        if (transform.position.y > -7)
        {
            Destroy(gameObject);
        }
    }
}
