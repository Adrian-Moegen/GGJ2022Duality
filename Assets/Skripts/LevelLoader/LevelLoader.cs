using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }


    public void LoadNextLevel()
    {
        int nextSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene(9);
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene(10);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
