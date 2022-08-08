using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A3Bgm : MonoBehaviour
{
    public AudioSource main;

    public AudioClip bgm;
    public AudioClip outside;

    public static A3Bgm Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    public void initbgm() => main.clip = bgm;
    public void initoutside() => main.clip = outside;

    public void PlaySound() => main.Play();
}
