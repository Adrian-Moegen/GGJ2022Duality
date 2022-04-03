using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textDisplay;
    [SerializeField] Image imageDisplay;
    [SerializeField] Image imageButton;
    BoxCollider2D boxCollider2D;

    //bool platform = false;

    private void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(TypeText());
        }
    }

    IEnumerator TypeText()
    {
        Time.timeScale = 0;
        textDisplay.enabled = true;
        imageDisplay.enabled = true;
        imageButton.enabled = true;

        while (!Input.GetKeyDown("e"))
        {
            yield return null;
        }

        textDisplay.enabled = false;
        imageDisplay.enabled = false;
        imageButton.enabled = false;
        Destroy(this);
        Time.timeScale = 1;
    }

}

