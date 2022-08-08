using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightFlicker : MonoBehaviour
{
    public bool alarmOn = true;
    // public float turnSpeed;
    public float highIntensity = 1f;
    public float lowIntensity = 0.1f;
    // private float targetIntensity = 0;
    Light2D _light;

    float lastFlickerTime = 0;
    float FlickerInterval = 0;


    void Start()
    {
        _light = gameObject.GetComponent<Light2D>();
        // targetIntensity = highIntensity;

        // _light.intensity = 2f;
    }

    void Update()
    {
        if (alarmOn)
        {
            // Debug.Log(Time.time);
            if (Time.time - lastFlickerTime > FlickerInterval)
            {
                // Debug.Log("Flicker");
                if (_light.intensity == highIntensity)
                {
                    _light.intensity = lowIntensity;
                }
                else
                {
                    _light.intensity = highIntensity;
                }
                FlickerInterval = Random.Range(0.2f, 0.8f);
                lastFlickerTime = Time.time;
            }
        }
    }
}