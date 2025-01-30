using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectScript : MonoBehaviour
{
    public GameObject wall;
    public Vector3 spawnpoint; 
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision Detected");
        if (collision.CompareTag("respawn"))
        {
            Debug.Log("jfjj");
            Instantiate(wall, spawnpoint, Quaternion.identity);
            Destroy(gameObject);
        }


    }
    //public float xdistance;
    //private void Update()
    //{
    //    if (this.transform.position.x <= xdistance)
    //    {
            
    //        Debug.Log("jfjj");
    //        Instantiate(wall, spawnpoint, Quaternion.identity);
    //        Destroy(gameObject);
    //    }
    //}
}
