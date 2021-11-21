using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEnd : MonoBehaviour
{
    public GameObject levelClear;
    public GameObject bg;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            levelClear.SetActive(true);
            bg.SetActive(true);
        }
    }
}
