using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class FinalPlot : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject higgs;
    bool onTrigger = false;
    DialogueRunner dr;

    void Start()
    {
        dr = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onTrigger)
        {
            dr.StartDialogue("Level4_Final");
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
