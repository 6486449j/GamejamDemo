using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Plot : MonoBehaviour
{
    // Start is called before the first frame update
    DialogueRunner dr;
    void Start()
    {
        dr = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        dr.StartDialogue("Level1_higgs");
    }
}
