using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x - speed, transform.position.y);
    }
}
