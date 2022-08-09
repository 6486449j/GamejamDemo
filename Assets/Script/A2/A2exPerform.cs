using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A2exPerform : MonoBehaviour
{
    public GameObject show1;
    public GameObject show2;
    // Start is called before the first frame update
    bool onTrigger = false;

    int i = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                i += 1;
            }
        }
        if (i == 2){
            show1.SetActive(true);
        }
        if(i == 3)
        {
            show2.SetActive(true);
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
