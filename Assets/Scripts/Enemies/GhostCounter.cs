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
        Debug.Log("adding to ghost count");
    }

    private void OnBecameInvisible()
    {
        fbehav.visibleGhosts--;
    }
}
