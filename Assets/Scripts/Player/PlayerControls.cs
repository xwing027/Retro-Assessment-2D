using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public static bool playing;
    HolyWater hWater;

    private void Awake()
    {
        Screen.SetResolution(Screen.height, Screen.height, true);
        hWater = GetComponent<HolyWater>();
    }

    void Update()
    {
        if (playing)
        {

            gameObject.SetActive(true);

            Vector2 movement;
            //assigns the x and y axis for player movement
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            //make the vector framerate independent - putting this here also means we dont have to *deltatime and speed again 
            movement *= Time.deltaTime;
            movement *= speed;

            //move by what we determined above w/ movement
            transform.Translate(movement);

            if (hWater.waterStore>= 0)
            {
                //can shoot
                if (Input.GetButtonDown("Fire1"))
                {
                    Instantiate(bullet, transform.position, transform.rotation);
                    hWater.waterStore--;
                }
            }
            

            //can get killed by enemy

            //clamp players position to inside the play field
            Vector2 clampPos = transform.position;
            clampPos.x = Mathf.Clamp(clampPos.x, -4.4f, 4.4f);
            clampPos.y = Mathf.Clamp(clampPos.y, -6f, 140f);

            transform.position = clampPos;
        }
    }
}
