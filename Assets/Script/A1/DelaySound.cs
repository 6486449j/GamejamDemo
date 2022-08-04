using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelaySound : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject levelmanager;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke("transfer", 3);
        Invoke("playhit", 2);
        Invoke("playhit", 1);
    }

    void playhit()
    {
        A1SoundManager.Instance.intihitsound();
        A1SoundManager.Instance.PlaySound();
    }
    void transfer()
    {
        A1SoundManager.Instance.inittransfer();
        A1SoundManager.Instance.PlaySound();
        levelmanager.GetComponent<PortalManager>().switchToI();
    }
}
