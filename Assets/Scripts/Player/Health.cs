using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image healthBar;
    public float health;
    public float maxHealth = 5;
    public bool isInvun;
    public GameObject player;
    public SpriteRenderer playerSprite;

    public GameObject levelFail;
    public GameObject levelBG;

    public void Awake()
    {
        if (PlayerPrefs.HasKey("CurrentHealth"))
        {
            health = PlayerPrefs.GetFloat("CurrentHealth");
        }
        else
        {
            Save();
        }
    }

    private void Start()
    {
        health = maxHealth;
        playerSprite = GameObject.Find("Player").GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        if (isInvun)
        {
            player.tag = "PlayerInvun";
            StartCoroutine("Flash");
            isInvun = false;
        }
        if (health <=0)
        {
            player.SetActive(false);
            levelFail.SetActive(true);
            levelBG.SetActive(true);
        }
        
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1); //manages health bar fill
    }

    #region Invulnerability
    public void ResetInvun()
    {
        player.tag = "Player";
        
    }

    IEnumerator Flash()
    { //is there a more efficient way of doing this? seems lengthy....
        playerSprite.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.2f);
        playerSprite.color = Color.white;
        yield return new WaitForSeconds(0.2f);
        playerSprite.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.2f);
        playerSprite.color = Color.white;
        yield return new WaitForSeconds(0.2f);
        playerSprite.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.2f);
        playerSprite.color = Color.white;
        playerSprite.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.2f);
        playerSprite.color = Color.white;
        yield return new WaitForSeconds(0.2f);
        playerSprite.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.2f);
        playerSprite.color = Color.white;
        yield return new WaitForSeconds(0.2f);
        playerSprite.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.2f);
        playerSprite.color = Color.white;
        ResetInvun();
        yield return null;
    }
    #endregion

    public void Save()
    {
        PlayerPrefs.SetFloat("CurrentHealth", health);
    }
}
