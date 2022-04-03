using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleWinCondition : MonoBehaviour
{

    [SerializeField] Druckplatte druckplatte1;
    [SerializeField] Druckplatte druckplatte2;
    [SerializeField] Druckplatte druckplatte3;

    public bool winCondition = false;


    void Update()
    {
        if (druckplatte1.onTrigger1 == true && druckplatte2.onTrigger1 == true && druckplatte3.onTrigger1 == true)
        {
            winCondition = true;
        }
        if (druckplatte1.onTrigger1 == false || druckplatte2.onTrigger1 == false || druckplatte3.onTrigger1 == false)
        {
            winCondition = false;
        }
    }
}
