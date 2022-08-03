using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1bgm : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource bgm1;
    public AudioSource bgm2;

    public static A1bgm Instance;

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
    public void playbgm1() => bgm1.Play();
    public void stopbgm1() => bgm1.Stop();
    public void playbgm2() => bgm2.Play();
    public void stopbgm2() => bgm2.Stop();
}
