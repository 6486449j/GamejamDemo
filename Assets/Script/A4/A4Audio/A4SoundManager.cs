using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A4SoundManager : MonoBehaviour
{
    public AudioSource main;
 
    public AudioClip opendoor;

    public static A4SoundManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    public void initdoor() => main.clip = opendoor;

    public void PlaySound()
    {
        main.Play();
    }

}
