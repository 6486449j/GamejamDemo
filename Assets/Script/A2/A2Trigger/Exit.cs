using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    bool onTrigger = false;

    void Update()
    {
        if (onTrigger)
        {
            if (Level2.isRun == true)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    //GOTO A3
                    Debug.Log("success");
                }
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
