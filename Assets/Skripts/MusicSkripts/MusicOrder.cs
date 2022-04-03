using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicOrder : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField] AudioClip chase;
    [SerializeField] AudioClip credits;
    [SerializeField] AudioClip titelmusik;

    GameObject sceneType;

    int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.sceneLoaded += OnSceneLoaded;
        sceneType = GameObject.Find("SceneType");
        AudioClipOrder();

    }

    void OnSceneLoaded(Scene currentSceneIndex, LoadSceneMode Single)
    {
        sceneType = GameObject.Find("SceneType");
        AudioClipOrder();
    }

    private void AudioClipOrder()
    {
        if(sceneType.tag == "Menu")
        {
            audioSource.Stop();
            audioSource.clip = titelmusik;
            audioSource.Play();
            audioSource.volume = PlayerPrefsController.GetMasterVolume();
        }
        if(sceneType.tag == "Level")
        {
            audioSource.Stop();
            audioSource.clip = chase;
            audioSource.Play();
            audioSource.volume = PlayerPrefsController.GetMasterVolume();
        }
        if(sceneType.tag == "Credits")
        {
            audioSource.Stop();
            audioSource.clip = credits;
            audioSource.Play();
            audioSource.volume = PlayerPrefsController.GetMasterVolume();
        }

    }
}
