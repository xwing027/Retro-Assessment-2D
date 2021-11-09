using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public CanvasGroup pause;

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
        if (pause.alpha == 0)
        {
            Time.timeScale = 0;
            pause.alpha = 1;
            pause.interactable = true;
        }
        else
        {
            Time.timeScale = 1;
            pause.alpha = 0;
            pause.interactable = false;
        }
        
    }
}
