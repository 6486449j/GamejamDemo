using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pre2 : MonoBehaviour
{
    bool onTrigger = false;
    void Update()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Level2.getpre2 = true;
                A2SoundManager.Instance.initpaper();
                A2SoundManager.Instance.PlaySound();
                GameObject.Destroy(this.gameObject);
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
