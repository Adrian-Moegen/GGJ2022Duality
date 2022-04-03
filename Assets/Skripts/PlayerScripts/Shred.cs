using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shred : MonoBehaviour
{
    LevelLoader levelLoader;

    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag == "Player")
       {
            levelLoader = FindObjectOfType<LevelLoader>();
            levelLoader.RestartLevel(); 
       }
    }
}
