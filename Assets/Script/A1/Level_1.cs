using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Level_1 : MonoBehaviour
{
    DialogueRunner dr;

    void Start()
    {
        dr = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
        dr.StartDialogue("Level1_Start");
    }

    void Update()
    {
    }

}
