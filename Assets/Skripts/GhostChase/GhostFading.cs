using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostFading : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Light")
        {
            spriteRenderer.enabled = false;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Light")
        {
            spriteRenderer.enabled = true;
        }
    }
}
