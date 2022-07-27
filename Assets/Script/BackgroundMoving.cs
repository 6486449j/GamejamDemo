using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BackgroundMoving : MonoBehaviour
{
    public List<GameObject> backgrounds = new List<GameObject>();
    public List<float> movingCoefficients = new List<float>();
    public Camera mainCamera;
    public float defaultMovingCoefficient = 0.2f;
    float lastCameraX = 0;

    void Start()
    {
        lastCameraX = mainCamera.transform.position.x;
    }
    void Update()
    {
        float cameraMoving = mainCamera.transform.position.x - lastCameraX;

        for (int i = 0; i < backgrounds.Count; i++)
        {
            float movingCoefficient = default;
            try
            {
                movingCoefficient = movingCoefficients[i];
            }
            catch (Exception e)
            {
                Debug.LogError(e.ToString());
            }
            backgrounds[i].transform.Translate(new Vector3(-cameraMoving * movingCoefficient, 0, 0));
        }
        lastCameraX = mainCamera.transform.position.x;
    }
}
