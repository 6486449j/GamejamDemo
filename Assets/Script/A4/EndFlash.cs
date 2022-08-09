using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFlash : MonoBehaviour
{
    bool onTrigger = false;
    public GameObject flash;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (onTrigger)
        {
            flash.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            onTrigger = true;
        }
    }
}
