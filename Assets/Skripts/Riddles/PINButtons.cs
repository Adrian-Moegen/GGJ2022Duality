using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PINButtons : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] string PIN = "1509";

    public bool winCondition = false;

    public void CheckPin()
    {
        if(inputField.text == PIN)
        {
            winCondition = true;
            Debug.Log("geht es?");
        }
    }



}
