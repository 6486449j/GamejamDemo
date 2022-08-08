using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1FirstTrigger : MonoBehaviour
{
    bool onTrigger = false;

    void Start()
    {
        
    }
    void Update()
    {
        if (onTrigger)
        {
            A1SoundManager.Instance.intihitsound();
            A1SoundManager.Instance.PlaySound();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            onTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            onTrigger = false;
        }
    }
}
