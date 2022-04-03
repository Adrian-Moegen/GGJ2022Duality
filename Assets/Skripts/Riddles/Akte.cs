using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Akte : MonoBehaviour
{
    [SerializeField] PINButtons pinButtons;
    [SerializeField] GameObject specialEvent;
    [SerializeField] GameObject dialogSpecial;

    private void Update()
    {
        CheckForFile();
    }

    private void CheckForFile()
    {
        if(pinButtons.winCondition == true)
        {
            specialEvent.SetActive(true);
            dialogSpecial.SetActive(true);
        }
    }

}
