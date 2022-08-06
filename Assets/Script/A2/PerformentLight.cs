using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformentLight : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject D1;
    public GameObject D2;
    public GameObject D3;
    public GameObject D4;
    public GameObject D5;
    public GameObject D6;

    bool D1s = true;
    bool D2s = true;
    bool D3s = true;
    bool D4s = true;
    bool D5s = true;
    bool D6s = true;

    public AudioClip break1;
    public AudioClip break2;

    void Update()
    {
        if (Level2.drug3 == true)
        {
            Invoke("bD1", 1);
            Invoke("bD2", 2);
            Invoke("bD3", 3);
            Invoke("bD4", 4);
            Invoke("bD5", 5);
            Invoke("bD6", 6);
        }      
    }

    //void log() => Debug.Log("continue?");
    void bD1()
    {
        if (D1s == true)
        {
            D1s = false;
            D1.SetActive(false);
            AudioSource.PlayClipAtPoint(break1, D1.transform.position);
            Destroy(D1.gameObject);
        }
    }
    void bD2()
    {
        if (D2s == true)
        {
            D2s = false;
            D2.SetActive(false);
            AudioSource.PlayClipAtPoint(break2, D2.transform.position);
            Destroy(D2.gameObject);
        }
    }
    void bD3()
    {
        if (D3s == true)
        {
            D3s = false;
            D3.SetActive(false);
            AudioSource.PlayClipAtPoint(break1, D3.transform.position);
            Destroy(D3.gameObject);
        }
    }
    void bD4()
    {
        if (D4s == true)
        {
            D4s = false;
            D4.SetActive(false);
            AudioSource.PlayClipAtPoint(break1, D4.transform.position);
            Destroy(D4.gameObject);
        }
    }
    void bD5()
    {
        if (D5s == true)
        {
            D5s = false;
            D5.SetActive(false);
            AudioSource.PlayClipAtPoint(break2, D5.transform.position);
            Destroy(D5.gameObject);
        }
    }
    void bD6()
    {
        if (D6s == true)
        {
            D6s = false;
            D6.SetActive(false);
            AudioSource.PlayClipAtPoint(break2, D6.transform.position);
            Destroy(D6.gameObject);
        }
    }
}
