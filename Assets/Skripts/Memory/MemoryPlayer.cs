using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryPlayer : MonoBehaviour
{
    public bool aufdecken1;
    public bool aufdecken2;

    public bool firstReveal;
    public bool secondReveal;

    public float ColourMatch1;
    public float ColourMatch2;

    public float winCondition;

    private bool Green;
    private bool Blue;
    private bool Red;


    public bool trueWinCondition = true;



    private void Start()
    {
        aufdecken1 = false;
        aufdecken2 = false;

        firstReveal = false;
        secondReveal = false;

        Green = false;
        Red = false;
        Blue = false;

        ColourMatch1 = 0;
        ColourMatch2 = 0;

        winCondition = 0;

        
    }

    private void Update()
    {


        if (aufdecken1 && Green)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                firstReveal = true;
                secondReveal = false;

                ColourMatch1 = 1;

               


            }
          
        }

        if (aufdecken1 && Blue)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                firstReveal = true;
                secondReveal = false;

                ColourMatch1 = 2;

            }

        }

        if (aufdecken1 && Red)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                firstReveal = true;
                secondReveal = false;

                ColourMatch1 = 3;

            }

        }

        if (aufdecken2 && Green)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                secondReveal = true;
                firstReveal = false;

                ColourMatch2 = 1;
            }
            else
            {
                secondReveal = false;
            }
        }

        if (aufdecken2 && Blue)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                secondReveal = true;
                firstReveal = false;

                ColourMatch2 = 2;
            }
            else
            {
                secondReveal = false;
            }
        }

        if (aufdecken2 && Red)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                secondReveal = true;
                firstReveal = false;

                ColourMatch2 = 3;
            }
            else
            {
                secondReveal = false;
            }
        }

        PairManager();
        WinCondition();


    }





    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (firstReveal != true)
        {
            if (collision.CompareTag("Green"))
            {
                aufdecken1 = true;
                aufdecken2 = false;

                Green = true;
                Red = false;
                Blue = false;
            }

            if (collision.CompareTag("Blue"))
            {
                aufdecken1 = true;
                aufdecken2 = false;

                Green = false;
                Red = false;
                Blue = true;

            }

            if (collision.CompareTag("Red"))
            {
                aufdecken1 = true;
                aufdecken2 = false;

                Green = false;
                Red = true;
                Blue = false;


            }


        }

        if (firstReveal)
        {
            if (collision.CompareTag("Green"))
            {
                aufdecken1 = false;
                aufdecken2 = true;

                Green = true;
                Red = false;
                Blue = false;
            }

            if (collision.CompareTag("Blue"))
            {
                aufdecken1 = false;
                aufdecken2 = true;

                Green = false;
                Red = false;
                Blue = true;

            }

            if (collision.CompareTag("Red"))
            {
                aufdecken1 = false;
                aufdecken2 = true;

                Green = false;
                Red = true;
                Blue = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (firstReveal != true)
        {
            if ((collision.CompareTag("Green") || (collision.CompareTag("Blue") || (collision.CompareTag("Red")))))
            {
                aufdecken1 = false;
                aufdecken2 = false;

            }

        }

        if (firstReveal)
        {
            if ((collision.CompareTag("Green") || (collision.CompareTag("Blue") || (collision.CompareTag("Red")))))
            {
                aufdecken2 = false;
                aufdecken1 = false;
            }
        }

    }

    void PairManager()
    {

        if (secondReveal)
        {


            if (winCondition == 0)
            {
                if (ColourMatch1 == ColourMatch2)
                {
                   
                    winCondition = 1;
                    secondReveal = false;
                }

                else if (ColourMatch1 != ColourMatch2)
                {
                    
                    winCondition = 0;
                    secondReveal = false;

                }
            }

            else if (winCondition == 1)
            {

                if (ColourMatch1 == ColourMatch2)
                {
                   
                    winCondition = 2;
                    secondReveal = false;
                }

                else if (ColourMatch1 != ColourMatch2)
                {
                   
                    winCondition = 0;
                    secondReveal = false;
                }
            }

            else if (winCondition == 2)
            {

                if (ColourMatch1 == ColourMatch2)
                {
                   
                    winCondition = 3;
                }

                else if (ColourMatch1 != ColourMatch2)
                {
                   
                    winCondition = 0;
                }
            }

        }
        else
        {
            secondReveal = false;
        }


    }

    void WinCondition()
    {
        if (winCondition == 1)
        {

        }
        if (winCondition == 2)
        {

        }

        if (winCondition == 3)
        {
            trueWinCondition = true;
        }
    }
}
