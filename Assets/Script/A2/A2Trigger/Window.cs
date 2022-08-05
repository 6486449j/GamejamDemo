using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    public GameObject metaldoor;
    bool onTrigger = false;
    static public bool thisfinish = false;

    void Update()
    {
        if (thisfinish == false)
        {
            if (onTrigger)
            {
                if (Level2.isFinish)
                {
                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        thisfinish = true;
                        A2SoundManager.Instance.initmetal();
                        A2SoundManager.Instance.PlaySound();
                        metaldoor.SetActive(false);
                    }
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        onTrigger = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        onTrigger = false;
    }
}
