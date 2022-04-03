using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInLight : MonoBehaviour
{

    public bool playerInLight = false;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerInLight = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerInLight = false;
        }
    }
}
