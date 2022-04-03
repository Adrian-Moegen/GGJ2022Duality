using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hilfsesel : MonoBehaviour
{
    [SerializeField] GameObject dialog2;

    SpriteRenderer spriteRenderer;

    public bool winCondition = false;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            dialog2.SetActive(true);
            spriteRenderer.enabled = false;
            winCondition = true;
        }
    }
}
