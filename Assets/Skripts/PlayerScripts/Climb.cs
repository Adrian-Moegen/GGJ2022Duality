using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : MonoBehaviour
{

    private float vertical;
    private float climbSpeed = 8f;
    private bool isLadder;
    private bool isClimbing;

    [SerializeField] private Rigidbody2D rb;

  

    void Update()
    {
        vertical = Input.GetAxis("Vertical");

        if(isLadder && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
        }
    }

    private void FixedUpdate()
    {
        if(isClimbing)
        {
            rb.gravityScale = 0;
            rb.velocity = new Vector2(rb.velocity.x, vertical * climbSpeed);
        }
        else
        {   
            //set gravity Scale back to normal value
           
            rb.gravityScale = 5f;   
        }
    }   

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ladder"))
        {
            isLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Ladder"))
        {
            isLadder = false;
            isClimbing = false;
        }
    }
}
