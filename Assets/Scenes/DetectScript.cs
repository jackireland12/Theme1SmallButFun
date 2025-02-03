using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectScript : MonoBehaviour
{
    public GameObject wall;
    //private Vector2 spawnPosition;
     points points;
    public static float baseScale = 1f;
    public static float scaleIncreasePerPoint = 0.05f;
    public static float transitionDuration = 0.5f; // Duration of smooth transition
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
        float randomScale = Random.Range(0.4f+(points.pointsCount/20.0f), 1.5f + (points.pointsCount/20.0f));
        newRing.transform.localScale = Vector3.one *randomScale; 

    }
    public static void UpdateRingScales()
    {
        GameObject[] rings = GameObject.FindGameObjectsWithTag("dead");
        foreach (GameObject ring in rings)
        {
           // ring.transform.localScale *= (1 + scaleIncreasePerPoint);
            ring.GetComponent<DetectScript>().StartCoroutine(SmoothScaleIncrease(ring));
        }
    }
    private static IEnumerator SmoothScaleIncrease(GameObject ring)
    {
        Vector3 startScale = ring.transform.localScale;
        Vector3 endScale = startScale * (1 + scaleIncreasePerPoint);
        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / transitionDuration);
            ring.transform.localScale = Vector3.Lerp(startScale, endScale, SmoothStep(t));
            yield return null;
        }

        ring.transform.localScale = endScale;
    }

    private static float SmoothStep(float t)
    {
        return t * t * (3f - 2f * t);
    }

}
