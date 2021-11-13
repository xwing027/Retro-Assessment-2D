using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    //public bool isAsteroid = false;
    public PointsHandler pointsHandler;

    public void Start()
    {
        pointsHandler = GameObject.Find("Points Handler").GetComponent<PointsHandler>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //are we touching another enemy?
        //do nothing

        //are we touching a bullet?
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Bullet touching");
            //destroy bullet, then destroy self
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (gameObject.tag =="Ghost1")
            {
                pointsHandler.Ghost1Points();
            }
            /*if (gameObject.tag == "Ghost2")
            {
                pointsHandler.E1Points();
            }
            if (gameObject.tag == "Ghost3")
            {
                pointsHandler.E2Points();
            }*/
        }

        //are we touching the player
        else if (collision.gameObject.tag == "Player")
        {
            //destroy player
            Destroy(collision.gameObject);
        }
    }
}
