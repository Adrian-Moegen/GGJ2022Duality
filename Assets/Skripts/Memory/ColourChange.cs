using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    private SpriteRenderer spri;



    private bool eActive;

    MemoryPlayer memory;

    private bool isColliding;


    private void Awake()
    {
        memory = GameObject.Find("Teen").GetComponent<MemoryPlayer>();
    }

    private void Start()
    {
        spri = GetComponent<SpriteRenderer>();
     

        isColliding = false;
        eActive = false;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            eActive = true;
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            eActive = false;
        }

        if (memory.winCondition == 0 && memory.firstReveal == false)
        {
            spri.color = Color.white;
        }

        if (isColliding && eActive)
        {
            if (memory.ColourMatch1 == 1 && memory.aufdecken1)
            {
                spri.color = Color.green;
              
            }
            if (memory.ColourMatch1 == 2 && memory.aufdecken1)
            {
                spri.color = Color.blue;
                
            }
            if (memory.ColourMatch1 == 3 && memory.aufdecken1)
            {
                spri.color = Color.red;
            }
            if (memory.ColourMatch2 == 1 && memory.aufdecken2)
            {
                spri.color = Color.green;
            }

            if (memory.ColourMatch2 == 2 && memory.aufdecken2)
            {
                spri.color = Color.blue;
            }
            if (memory.ColourMatch2 == 3 && memory.aufdecken2)
            {
                spri.color = Color.red;
            }


        }












    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            isColliding = true;


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isColliding = false;
        }
    }
}
