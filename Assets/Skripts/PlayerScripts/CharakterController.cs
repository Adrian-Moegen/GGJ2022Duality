using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharakterController : MonoBehaviour
{
    //All Components
    private Rigidbody2D rb;
    private CapsuleCollider2D coll;
    private Animator anim;


    //Movement Variables
    private bool moveLeft;
    private bool moveRight;

  
    

    public float movespeed = 10f;
    public float jumpforce = 10f;

    //Ground Check Variables 
    const float groundCheckRadius = 0.5f;
    [SerializeField] bool isgrounded = false;
    [SerializeField] Transform groundCheckCollider;
    [SerializeField] LayerMask groundLayer;
    
    //Finite State Machine
    private State state = State.idle;
    private enum State {idle, running, jumping, falling, attacking}







    
    void Start()
    {
        //Movement Components
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        moveLeft = false;
        moveRight = false;

       
        
  

        //Ground Check Compnents
        coll = GetComponent<CapsuleCollider2D>();
       
        state = State.idle;

    }

    
    void Update()
    {
        StateMachine();
        anim.SetInteger("state", (int)state);

        GroundCheck();

        // Key Input (left + right)

        if (Input.GetKey(KeyCode.A))
        {
            moveLeft = true;
            
        }

        else
        {
            moveLeft = false;
           
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveRight = true;
          
        }

        else
        {
            moveRight = false;
            
        }

        // Key Imput (jumping)
      
       if(isgrounded)
       {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce);

                state = State.jumping;
            }
       }
    }

    private void FixedUpdate()
    {
        if (moveLeft)
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
            transform.localScale = new Vector2((float)-.3, (float).3);                     //flip Sprite
        }

        else
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
        }

        if (moveRight)
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
            transform.localScale = new Vector2((float).3, (float).3);                        //flip Sprite
        }

        else
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
        }

    }

    private void StateMachine()
    {
        if(state == State.jumping)
        {
            if(rb.velocity.y < 0.1f)
            {
                state = State.falling;
                
            }
        }
        
        else if(state == State.falling)
        {
            if(isgrounded)
            {
                state = State.idle;
            }
        }
        else if(Mathf.Abs(rb.velocity.x ) > 0.2f)  
        {
           
            
                state = State.running;
            
        }
        
        else
        {
            state = State.idle;
        }
        
    }

    void GroundCheck()
    {
        isgrounded = false;

        Collider2D[] collider = Physics2D.OverlapCircleAll(groundCheckCollider.position, groundCheckRadius, groundLayer);
        if(collider.Length > 0)
        {
            isgrounded = true;
        }
        else
        {
            isgrounded = false;
           
        }
           
    }

}
