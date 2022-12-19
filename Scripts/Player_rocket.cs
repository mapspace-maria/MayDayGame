using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_rocket : MonoBehaviour
{
    private Vector2 moveInput;

    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;


    
    // Update is called once per frame
    void Update()
    {    

            ProcessInputs();

    }

    private void FixedUpdate()
    {
        Move();
    }

     void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(moveX, moveY).normalized;
    }
 
    void Move()
    {
        rb.velocity = new Vector2(moveInput.x * speed, moveInput.y * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Alien")
        {
            //Scoring.Score += 10;
            Destroy (gameObject);

        }

    }

}
