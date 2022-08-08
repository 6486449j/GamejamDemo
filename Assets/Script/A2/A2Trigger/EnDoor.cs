using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class EnDoor : MonoBehaviour
{
    public GameObject light_;

    Light2D lights;
    public float intensity = 0.1f;
    bool isin=false;
    void Start()
    {
        lights = light_.GetComponent<Light2D>();
    }
    void Update()
    {
        if (isin)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                A2BoundList.Instance.hospital();
                A2Bgm.Instance.initmain();
                A2Bgm.Instance.PlaySound();
                A2Footstep.Instance.initfloor();
                lights.intensity = intensity;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isin = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isin = false;
    }
}
