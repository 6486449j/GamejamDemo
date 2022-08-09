using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class ExitDoor : MonoBehaviour
{
    bool onTrigger = false;
    Level_3 l3;
    TextMeshProUGUI tmp;
    Animator at;
    DialogueRunner dr;

    void Start()
    {
        l3 = GameObject.Find("LevelManager").GetComponent<Level_3>();
        tmp = GameObject.Find("KeyCount").GetComponent<TextMeshProUGUI>();
        at = GameObject.Find("Cover").GetComponent<Animator>();
        dr = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && onTrigger)
        {
            if (l3.getkey)
            {
                // Debug.Log("Exit the scene");
                l3.getkey = false;
                tmp.text = "0";
                StartCoroutine(LoadScene());
            }
            else
            {
                dr.StartDialogue("Level3_ExitDoor");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            onTrigger = true;
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            onTrigger = false;
        }
    }

    IEnumerator LoadScene()
    {
        at.SetTrigger("Start");
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level_3_1");
    }
}
