using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairDown : MonoBehaviour
{
    public GameObject floor1;
    public GameObject floor2;
    public GameObject lights;

    bool onTrigger=false;

    void Update()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                floor1.SetActive(false);
                floor2.SetActive(true);
                lights.SetActive(false);
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
