using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class NewspaperTrigger : MonoBehaviour
{
    DialogueRunner dr;
    GameObject newspaper;
    // Start is called before the first frame update
    void Start()
    {
        newspaper = GameObject.Find("Newspaper");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && newspaper.activeSelf)
        {
            newspaper.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dr = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
            dr.StartDialogue("Level1_Start");
        }
    }
}
