using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLevelLoader : MonoBehaviour
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
}
