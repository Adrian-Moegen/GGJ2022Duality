using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowPin : MonoBehaviour
{

    [SerializeField] Druckplatte druckplatte;
    [SerializeField] GameObject pinHintRiddle;
    [SerializeField] GameObject pinRiddle;
    [SerializeField] GameObject inputField;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(druckplatte.onTrigger1 == true)
            {
                pinHintRiddle.SetActive(true);
                inputField.SetActive(true);
            }
            if(druckplatte.onTrigger1 == false)
            {
                pinRiddle.SetActive(true);
                inputField.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(druckplatte.onTrigger1 == true)
            {
                pinHintRiddle.SetActive(false);
                inputField.SetActive(false);
            }
            if(druckplatte.onTrigger1 == false)
            {
                pinRiddle.SetActive(false);
                inputField.SetActive(false);
            }
        }
    }
}
