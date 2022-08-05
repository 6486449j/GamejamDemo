using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drug1 : MonoBehaviour
{
    bool onTrigger = false;
    void Update()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Level2.drug1 = true;
                A2SoundManager.Instance.initdrug();
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
