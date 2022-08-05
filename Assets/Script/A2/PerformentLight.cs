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
    void bD1() { D1.SetActive(false); AudioSource.PlayClipAtPoint(break1, D1.transform.position); Destroy(D1.gameObject); }
    void bD2() { D2.SetActive(false); AudioSource.PlayClipAtPoint(break2, D2.transform.position); Destroy(D2.gameObject); }
    void bD3() { D3.SetActive(false); AudioSource.PlayClipAtPoint(break1, D3.transform.position); Destroy(D3.gameObject); }
    void bD4() { D4.SetActive(false); AudioSource.PlayClipAtPoint(break1, D4.transform.position); Destroy(D4.gameObject); }
    void bD5() { D5.SetActive(false); AudioSource.PlayClipAtPoint(break2, D5.transform.position); Destroy(D5.gameObject); }
    void bD6() { D6.SetActive(false); AudioSource.PlayClipAtPoint(break2, D6.transform.position); Destroy(D6.gameObject); }
}
