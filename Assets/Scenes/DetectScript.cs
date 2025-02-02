using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectScript : MonoBehaviour
{
    public GameObject wall;
    //private Vector2 spawnPosition;
     points points;
    private void Start()
    {
        var spawnPosition = new Vector2( 10.0f, Random.Range(-10.0f, 10.0f));
        points = GameObject.FindGameObjectWithTag("Player").GetComponent<points>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision Detected");
        if (collision.CompareTag("respawn"))
        {
            spawnObject();
        }


    }
    private void spawnObject()
    {
        Debug.Log("spawnPosition");
        GameObject newRing = Instantiate(wall, new Vector2(10.0f, Random.Range(-5.0f, 5.0f)), Quaternion.identity);
        Destroy(gameObject);
        float randomScale = Random.Range(0.5f+points.pointsCount/7, 2f + points.pointsCount/7);
        newRing.transform.localScale = Vector3.one *randomScale; 
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
