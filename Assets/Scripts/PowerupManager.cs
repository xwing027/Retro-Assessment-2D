using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    public GameObject bullet;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Powerup1")
        {
            StartCoroutine(Powerup1());
            Destroy(collision.gameObject);
        }
    }

    IEnumerator Powerup1()
    {
        Instantiate(bullet, transform.position, Quaternion.Euler(0f, 0f, 0f)); //spawn bullets at even angles 
        Instantiate(bullet, transform.position, Quaternion.Euler(0f, 0f, 45f));
        Instantiate(bullet, transform.position, Quaternion.Euler(0f, 0f, 90f));
        Instantiate(bullet, transform.position, Quaternion.Euler(0f, 0f, 135f));
        Instantiate(bullet, transform.position, Quaternion.Euler(0f, 0f, 180f));
        Instantiate(bullet, transform.position, Quaternion.Euler(0f, 0f, 225f));
        Instantiate(bullet, transform.position, Quaternion.Euler(0f, 0f, 270f));
        Instantiate(bullet, transform.position, Quaternion.Euler(0f, 0f, 315f));
        Instantiate(bullet, transform.position, Quaternion.Euler(0f, 0f, 360f));
        yield return new WaitForSeconds(1f); //wait one second
        StartCoroutine("Powerup1"); //spawn bullets again
        yield return new WaitForSeconds(1f);
        StartCoroutine("Powerup1");
        yield return new WaitForSeconds(1f);
        StartCoroutine("Powerup1");
        yield return new WaitForSeconds(1f);
        StartCoroutine("Powerup1");
        yield return new WaitForSeconds(1f);
        StartCoroutine("Powerup1");
        StopCoroutine("Powerup1"); //stop after 7 times
    }
}
