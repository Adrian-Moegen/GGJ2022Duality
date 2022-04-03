using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoastEyes : MonoBehaviour
{
    LevelLoader levelLoader;

    private bool hidden;
    private bool inDeathZone;

    private void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>();

        hidden = false;
        inDeathZone = false;
    }

    private void Update()
    {
        if (inDeathZone && hidden != true)
        {
            // Player dies
            levelLoader.RestartLevel();
        }
        else if (inDeathZone && hidden)
        {
            //Player is still alive
            Debug.Log("luckely the Player survived the red eyed demon");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Hide"))
        {
            hidden = true;

        }

        if (collision.CompareTag("DeathZone"))
        {
            inDeathZone = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {


        if (collision.CompareTag("Hide"))
        {
            hidden = false;

        }

        if (collision.CompareTag("DeathZone"))
        {
            inDeathZone = false;

        }
    }
}
