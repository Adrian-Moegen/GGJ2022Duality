using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dying : MonoBehaviour
{

    CircleCollider2D myCircleCollider2D;
    LevelLoader LevelLoader;


    // Start is called before the first frame update
    void Start()
    {
        myCircleCollider2D = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Die();
    }

    public void Die()
    {
        if (myCircleCollider2D.IsTouchingLayers(LayerMask.GetMask("Player")))
        {            
            LevelLoader = FindObjectOfType<LevelLoader>();
            LevelLoader.RestartLevel();
        }
    }
}
