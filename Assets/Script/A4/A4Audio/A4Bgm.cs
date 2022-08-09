using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A4Bgm : MonoBehaviour
{
    public AudioSource main;
    public AudioClip MainBgm;
    public AudioClip EnterBgm;
    public AudioClip FinalBgm;
    public AudioClip EndBgm;

    public static A4Bgm Instance;

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
    public void initfinal() => main.clip = FinalBgm;
    public void initend() => main.clip = EndBgm;
    public void PlaySound()
    {
        main.Play();
    }
}
