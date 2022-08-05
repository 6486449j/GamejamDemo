using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    bool onTrigger = false;
    Level_3 l3;
    TextMeshProUGUI tmp;
    Animator at;

    void Start()
    {
        l3 = GameObject.Find("LevelManager").GetComponent<Level_3>();
        tmp = GameObject.Find("KeyCount").GetComponent<TextMeshProUGUI>();
        at = GameObject.Find("Cover").GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && l3.getkey)
        {
            // Debug.Log("Exit the scene");
            l3.getkey = false;
            tmp.text = "0";
            StartCoroutine(LoadScene());
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
        SceneManager.LoadScene("Level_1");
    }
}
