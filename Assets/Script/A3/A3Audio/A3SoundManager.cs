using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A3SoundManager : MonoBehaviour
{
    public AudioSource main;

    public AudioClip opendoor;
    public AudioClip getkey;

    public static A3SoundManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    public void initdoor() => main.clip = opendoor;
    public void initget() => main.clip = getkey;

    public void PlaySound() => main.Play();
}
