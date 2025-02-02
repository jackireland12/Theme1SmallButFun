using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    public int pointsCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("point"))
        {
            pointsCount++;
            Debug.Log(pointsCount);
        }
        else
        {
            //null;
        }
        
    }
}
