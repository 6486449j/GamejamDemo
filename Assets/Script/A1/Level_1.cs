using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Level_1 : MonoBehaviour
{
    DialogueRunner dr;
    GameObject newspaper;

    void Start()
    {
        dr = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
        dr.StartDialogue("Level1_Start");

        newspaper = GameObject.Find("Newspaper");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && newspaper.activeSelf)
        {
            newspaper.SetActive(false);
        }
    }

}
