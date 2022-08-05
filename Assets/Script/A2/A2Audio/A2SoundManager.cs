using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A2SoundManager : MonoBehaviour
{
    public AudioSource main;

    public AudioClip paper;
    public AudioClip drug;
    public AudioClip openmetaldoor;
    public AudioClip opendoor;

    public AudioClip break1;
    public AudioClip break2;

    public static A2SoundManager Instance;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void initpaper() => main.clip = paper;
    public void initdrug() => main.clip = drug;
    public void initmetal() => main.clip = openmetaldoor;

    public void initbreak1() => main.clip = break1;
    public void initbreak2() => main.clip = break2;

    public void PlaySound()
    {
        main.Play();
        //main.
        //AudioSource.PlayClipAtPoint
    }

}
