using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private float leftCap;
    [SerializeField] private float rightCap;


    [SerializeField] private float moveSpeed = 5f;

    private bool facingLeft = true;


    private Collider2D coll;
    [SerializeField] private Rigidbody2D rb;



    private void Start()
    {
        GetComponent<Collider2D>();



    }

    private void FixedUpdate()
    {

        if (facingLeft)
        {
            if (transform.position.x > leftCap)
            {
                rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            }
            else
            {
                facingLeft = false;
            }
        }

        else
        {
            if (transform.position.x < rightCap)
            {
                rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            }
            else
            {
                facingLeft = true;
            }
        }

    }
}