using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Pre1 : MonoBehaviour
{
    bool onTrigger = false;
    DialogueRunner dr;

    void Start()
    {
        dr = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
    }
    void Update()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Level2.getpre1 = true;
                A2SoundManager.Instance.initpaper();
                A2SoundManager.Instance.PlaySound();
                GameObject.Destroy(this.gameObject);
                dr.StartDialogue("Level2_Pre1");
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
