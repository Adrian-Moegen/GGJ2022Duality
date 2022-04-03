using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Druckplatte : MonoBehaviour
{

    public bool onTrigger1;


    // Start is called before the first frame update
    void Start()
    {
        onTrigger1 = false;

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Trigger1")
        {
            onTrigger1 = true;

            Debug.Log("Trigger1 set true");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Trigger1")
        {
            onTrigger1 = false;

            Debug.Log("Trigger1 set false");
        }

    }

}
