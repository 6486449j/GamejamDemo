using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1SoundManager : MonoBehaviour
{
    public AudioSource audio;

    public AudioClip OpenDoor;
    public AudioClip A1bgm;
    public AudioClip laugh;
    public AudioClip hitsound;
    public AudioClip transfersound;
    public AudioClip paper;

    public static A1SoundManager Instance;

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
        //audio = GetComponent<AudioSource>();
        audio.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void intiOpenDoor() => audio.clip = OpenDoor;
    public void intiA1bgm() => audio.clip = A1bgm;
    public void intiLaugh() => audio.clip = laugh;
    public void intihitsound() => audio.clip = hitsound;
    public void inittransfer() => audio.clip = transfersound;
    public void initpaper() => audio.clip = paper;

    public void PlaySound()
    {
        audio.Play();
    }
}
