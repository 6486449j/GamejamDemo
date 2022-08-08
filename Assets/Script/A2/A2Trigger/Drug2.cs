using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Drug2 : MonoBehaviour
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
                Level2.drug2 = true;
                A2SoundManager.Instance.initdrug();
                A2SoundManager.Instance.PlaySound();
                GameObject.Destroy(this.gameObject);
                dr.StartDialogue("Level2_d_r");
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
