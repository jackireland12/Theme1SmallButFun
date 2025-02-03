using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Camera mainCamera;
    public float sizeIncreasePerPoint = 0.2f; // Adjust this value
    public float transitionDuration = 0.5f; // Duration of the smooth transition

    void Start()
    {
        // Automatically find the main camera if not assigned
        if (!mainCamera) mainCamera = Camera.main;
    }

    public void IncreaseFOV()
    {
        StartCoroutine(SmoothIncreaseFOV());
    }

    private IEnumerator SmoothIncreaseFOV()
    {
        float startSize = mainCamera.orthographicSize;
        float endSize = startSize + sizeIncreasePerPoint;
        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / transitionDuration);
            mainCamera.orthographicSize = Mathf.Lerp(startSize, endSize, SmoothStep(t));
            yield return null;
        }

        mainCamera.orthographicSize = endSize;
    }

    private float SmoothStep(float t)
    {
        return t * t * (3f - 2f * t);
    }
}
