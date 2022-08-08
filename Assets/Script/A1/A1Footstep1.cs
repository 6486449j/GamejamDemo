using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1Footstep1 : MonoBehaviour
{
    public AudioSource audios;

    public AudioClip grass;

    public Rigidbody2D rgdBody;

    public static A1Footstep1 Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    void Start()
    {
        audios.loop = true;
        audios.clip = grass;
        audios.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs( rgdBody.velocity.x) > 1f && Mathf.Abs(rgdBody.velocity.y) <0.1f)
        {
            playsound();
        }
        else
        {
            stopsound();
        }
        
    }
    public void play()
    {
        //audios.
    }
    public void playsound() => audios.enabled = true;
    public void stopsound() => audios.enabled = false;
}
