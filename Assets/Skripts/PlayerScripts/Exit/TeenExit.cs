using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeenExit : MonoBehaviour
{
    [SerializeField] MemoryPlayer memoryPlayer;

    BoxCollider2D myBoxCollider2D;
    LevelLoader LevelLoader;

    private void Start()
    {
        myBoxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        ToNextLevel();
    }

    private void ToNextLevel()
    {
        if (myBoxCollider2D.IsTouchingLayers(LayerMask.GetMask("Player")) && memoryPlayer.trueWinCondition == true)
        {
            LevelLoader = FindObjectOfType<LevelLoader>();
            LevelLoader.LoadNextLevel();
        }
    }
}
