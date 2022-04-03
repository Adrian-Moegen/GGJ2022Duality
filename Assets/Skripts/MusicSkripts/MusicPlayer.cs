using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;

    void OnEnable()
    {
        DontDestroyOnLoad(this);
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.volume = PlayerPrefsController.GetMasterVolume();

    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
