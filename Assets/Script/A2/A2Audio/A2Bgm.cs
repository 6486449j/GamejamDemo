using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A2Bgm : MonoBehaviour
{
    public AudioSource main;
    public AudioClip MainBgm;
    public AudioClip EnterBgm;
    public AudioClip ChaseBgm;

    public static A2Bgm Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    public void initmain() => main.clip = MainBgm;
    public void initenter() => main.clip = EnterBgm;
    public void initchase() => main.clip = ChaseBgm;
    public void PlaySound()
    {
        main.Play();
    }
}
