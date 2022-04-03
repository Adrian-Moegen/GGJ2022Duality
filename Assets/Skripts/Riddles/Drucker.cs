using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drucker : MonoBehaviour
{
    [SerializeField] Collectable colletable;
    [SerializeField] GameObject druckerNoLight;
    [SerializeField] GameObject druckerLight;

    private void CheckForCollectable()
    {
        if(colletable.collected == true)
        {
            druckerNoLight.SetActive(false);
            druckerLight.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            CheckForCollectable();
        }
    }
}
