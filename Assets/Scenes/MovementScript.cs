using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 velcity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velcity = new Vector2(0.1f,0f);
    }

    private void Update()
    {
        if (Input.GetKeyDown("w"))
        {
           
        }
        if (Input.GetKeyDown("s"))
        {

        }
    }

}
