using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    public float pointsCount;
    DetectScript ds;
    private void Start()
    {
        ds  = GameObject.FindGameObjectWithTag("dead").GetComponent<DetectScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("point"))
        {
            pointsCount++;
            Debug.Log(pointsCount);
            DetectScript.UpdateRingScales();
            GameObject.FindGameObjectsWithTag("dead");
            if (tag == "dead")
            {

                ds.transform.localScale = Vector3.one * (pointsCount);
                
            }

            
        }
        else
        {
            //null;
        }
        
    }
}
