using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueHandler : MonoBehaviour
{
    public DialogueRunner dr;
    public string node;

    void Start()
    {

    }

    void Update()
    {

    }

    public void StartDialogue()
    {
        dr.Stop();
        dr.StartDialogue(node);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        dr.Stop();
        dr.StartDialogue(node);
    }

    void OnTriggerExit2d(Collider2D collider)
    {
        dr.Stop();
        dr.Clear();
    }
}
