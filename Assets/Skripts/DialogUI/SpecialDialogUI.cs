using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpecialDialogUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textDisplay;
    [SerializeField] Image imageDisplay;
    [SerializeField] Image imageButton;
    [SerializeField] Image imageFile;
    [SerializeField] Image imageGraveHint;
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
        imageFile.enabled = true;
        imageGraveHint.enabled = true;

        while (!Input.GetKeyDown("e"))
        {
            yield return null;
        }

        textDisplay.enabled = false;
        imageDisplay.enabled = false;
        imageButton.enabled = false;
        imageFile.enabled = false;
        imageGraveHint.enabled = false;

        Destroy(this);
        Time.timeScale = 1;
    }
}
