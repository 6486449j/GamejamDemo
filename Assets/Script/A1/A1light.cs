using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1light : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject light;
    public GameObject background;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        A1SoundManager.Instance.inittransfer();
        A1SoundManager.Instance.PlaySound();
        A1bgm.Instance.stopbgm1();
        A1bgm.Instance.playbgm2();
        background.SetActive(false);
        //light.GetComponent<Li>().intensity = 0.15f;
        light.SetActive(false);

    }
}
