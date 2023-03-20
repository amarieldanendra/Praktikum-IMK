using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandling : MonoBehaviour
{
    public GameObject pauseMenu;

    void Start()
    {
        if(pauseMenu != null)
        {
            pauseMenu.SetActive(false);
        }
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void PauseGame()
    {
        Time.timeScale = 0.0f;
        pauseMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
