using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlay : MonoBehaviour
{
    bool onTrigger = false;
    void Update()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                A2SoundManager.Instance.inithit();
                A2SoundManager.Instance.PlaySound();
            }
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
