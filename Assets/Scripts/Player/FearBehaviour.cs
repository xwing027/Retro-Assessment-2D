using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FearBehaviour : MonoBehaviour
{
    public float visibleGhosts;
    public Image fearBar;
    float fear;
    float fearMax=5;
    bool isScared = false;

    PlayerControls playerCon;
    public Text pressF;

    private void Start()
    {
        playerCon = GetComponent<PlayerControls>();
        pressF.enabled = false;
    }

    private void Update()
    {
        fear = visibleGhosts;

        if (Input.GetButtonDown("Submit"))//visibleGhosts >=fearMax)
        {
            Scared();
        }
        if (isScared)
        {
            if (Input.GetKeyDown("F"))
            {
                //kill half of enemies on screen - has to be enough to lower fear bar

                //allow movement
                playerCon.speed = 6;
                //set player health to 1 momentarily (do so without showing on health bar?)
                //reset fear - will happen anyway with the ghosts dying
            }
        }
        fearBar.fillAmount = Mathf.Clamp(fear / fearMax, 0, 1);
    } 

    void Scared()
    {
        isScared = true;
        playerCon.speed = 0;
        pressF.enabled = true;
    }
}
