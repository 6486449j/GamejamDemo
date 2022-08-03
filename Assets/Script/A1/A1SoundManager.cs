using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1SoundManager : MonoBehaviour
{
    public AudioSource audio;

    public AudioClip OpenDoor;
    public AudioClip A1bgm;
    public AudioClip laugh;


    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaySound(AudioClip ac)
    {
        audio.clip = ac;
        audio.Play();
    }
}
