using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyBox : MonoBehaviour
{
    public Notice nt;
    Level_3 l3;
    // TextMeshPro tmp;
    TextMeshProUGUI tmp;

    bool onTrigger = false;

    void Start()
    {
        l3 = GameObject.Find("LevelManager").GetComponent<Level_3>();
        tmp = GameObject.Find("KeyCount").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && onTrigger && l3.getkey == false)
        {
            // Debug.Log("Got key");
            l3.getkey = true;
            tmp.text = "1";
            nt.show = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        onTrigger = true;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        onTrigger = false;
    }
}
