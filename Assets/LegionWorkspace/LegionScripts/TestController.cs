using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestController : MonoBehaviour
{

    [SerializeField] float movementSpeed = 3f;

    // Start is called before the first frame update
     private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        Moving();
    }

    private void Moving()
    {
        if(Input.GetKey("d"))
        {
            transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
        }
    }
}
