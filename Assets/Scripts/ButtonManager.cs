using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject pause;
    public GameObject instructions;
    public GameObject bg;
    public Health healthScript;

    private void Start()
    {
        Time.timeScale = 0;
        PlayerControls.playing = false;
        instructions.SetActive(true);
        bg.SetActive(true);
        healthScript = GameObject.Find("Health Manager").GetComponent<Health>();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Pause()
    {
        if (pause.activeSelf == false)
        {
            Time.timeScale = 0;
            pause.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pause.SetActive(false);
        }
        
    }

    public void Continue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        healthScript.Save();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Instructions()
    {
        Time.timeScale = 1;
        instructions.SetActive(false);
        bg.SetActive(false);
        PlayerControls.playing = true;
    }
}
