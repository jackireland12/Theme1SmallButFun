using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 velocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(0f,0.15f);
    }

    private void Update()
    {
        if (Input.GetKey("w"))
        {
           rb.MovePosition(rb.position + velocity);
        }
        if (Input.GetKey("s"))
        {
            rb.MovePosition(rb.position - velocity);
        }
    }

}
