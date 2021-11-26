using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class HolyWater : MonoBehaviour
{
    public Image waterBar;
    public float waterStore;
    public float waterBonus = 7;
    public float maxWater = 15;

    private void Awake()
    {
        waterStore = PlayerPrefs.GetFloat("CurrentWater", maxWater);
#if UNITY_EDITOR
        PlayerPrefs.DeleteAll();
#endif
    }

    private void Start()
    {
        //waterStore = maxWater;
    }

    private void Update()
    {
        waterBar.fillAmount = Mathf.Clamp(waterStore / maxWater, 0, 1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Water Bonus")
        {
            waterStore += waterBonus;
            if (waterStore > maxWater)
            {
                waterStore = maxWater;
            }

            Destroy(collision.gameObject,0.2f);
        }
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("CurrentWater", waterStore);
    }
}
