using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class MainPerform : MonoBehaviour
{
    // Start is called before the first frame update
    Light2D _light;
    bool onTrigger = false;

    void Start()
    {
        _light = gameObject.GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
       // _light.color = Color.red;
       if(onTrigger) _light.color = Color.red;
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
