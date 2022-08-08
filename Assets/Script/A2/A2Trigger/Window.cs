using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Window : MonoBehaviour
{
    public GameObject metaldoor;
    //public Animator anim;
    bool onTrigger = false;
    static public bool thisfinish = false;
    DialogueRunner dr;

    void Start()
    {
        dr = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
    }

    void Update()
    {
        if (thisfinish == false)
        {
            if (onTrigger)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    if (Level2.isFinish)
                    {
                        thisfinish = true;
                        A2SoundManager.Instance.initmetal();
                        A2SoundManager.Instance.PlaySound();
                        metaldoor.SetActive(false);
                    }
                    else
                    {
                        dr.StartDialogue("Level2_window");
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
