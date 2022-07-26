using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class A1light : MonoBehaviour
{
    // Start is called before the first frame update
    // public Light light;
    public GameObject light_;
    public GameObject background;
    Light2D lights;
    public float intensity = 0.15f;

    void Start()
    {
        lights = light_.GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        A1SoundManager.Instance.intihitsound();
        A1SoundManager.Instance.PlaySound();
        A1bgm.Instance.stopbgm1();
        A1bgm.Instance.playbgm2();
        background.SetActive(false);
        //light.GetComponent<Li>().intensity = 0.15f;
        lights.intensity = intensity;

    }
}
