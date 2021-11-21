using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FearBehaviour : MonoBehaviour
{
    public int visibleGhosts;
    public Image fearBar;
    float fear;
    float fearMax=5;
    public bool isScared = false;
    int ghostsToKill;

    PlayerControls playerCon;
    Health health;
    public Text pressF;
    public List<GameObject> ghosts; //might need to make static?

    private void Start()
    {
        playerCon = GetComponent<PlayerControls>();
        health = GameObject.Find("Health Manager").GetComponent<Health>();
        
        pressF.enabled = false;       
    }

    private void Update()
    {
        fear = visibleGhosts;

        if (fear >=fearMax)
        {
            Scared();
        }
        if (isScared)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Pray();
            }
        }
        fearBar.fillAmount = Mathf.Clamp(fear / fearMax, 0, 1);

        ghostsToKill = Mathf.Clamp(ghosts.Count / 2, 0, 4);
    } 

    void Scared()
    {
        isScared = true;
        playerCon.speed = 0;
        pressF.enabled = true;
        //temp kill player if touched regardless of health 
    }

    void Pray()
    {
        //kill half of enemies on screen - has to be enough to lower fear bar
        Destroy(ghosts[ghosts.Count - (visibleGhosts / 2)].gameObject);
        for (int i = 0; i < ghostsToKill; i++)
        {
            Destroy(ghosts[ghosts.Count -1]);
        }
        
        //allow movement
        playerCon.speed = 6;
        pressF.enabled = false;
        isScared = false;
    }
}
