using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A31Bgm : MonoBehaviour
{
    public AudioSource main;
    public AudioSource main2;

    public AudioClip bgm;

    public static A31Bgm Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    public void initbgm()
    { 
        main.clip = bgm;
        main2.clip = bgm;
    }
    public void PlaySound()
    {
        main.Play();
        main2.PlayDelayed(10f);
    }
}
