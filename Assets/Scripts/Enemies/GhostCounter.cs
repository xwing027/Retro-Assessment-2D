using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostCounter : MonoBehaviour
{
    FearBehaviour fbehav;
    

    private void Start()
    {
        fbehav = GameObject.Find("Player").GetComponent<FearBehaviour>();
    }

    private void OnBecameVisible()
    {
        fbehav.visibleGhosts++;
        fbehav.ghosts.Add(gameObject);
    }

    private void OnBecameInvisible()
    {
        fbehav.visibleGhosts--;
        fbehav.ghosts.Remove(gameObject);
    }
}
