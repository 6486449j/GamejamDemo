using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairUp : MonoBehaviour
{
    public GameObject floor1;
    public GameObject floor2;
    public GameObject ban;

    bool onTrigger = false;

    void Update()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                floor1.SetActive(true);
                floor2.SetActive(false);
                if (Level2.isRun == true)
                {
                    ban.SetActive(false);
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
