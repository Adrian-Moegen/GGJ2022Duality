using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    BoxCollider2D boxCollider2D;

    public bool collected;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            collected = true;
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;
            Debug.Log(collected);
        }
    }
}
