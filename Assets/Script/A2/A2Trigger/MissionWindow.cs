using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class MissionWindow : MonoBehaviour
{
    public GameObject metaldoor;
    public GameObject exitdoor;
    public GameObject higgs;
    public Animator anim;
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
            if (Input.GetKeyDown(KeyCode.Z))
            {
                metaldoor.SetActive(true);
                ChangeSprite(exitdoor, "Doubledoor_open");
                Level2.isRun = true;
                anim.SetBool("isTrigger", true);
                Invoke("delay",1);
                higgs.SetActive(true);
            }
        }
    }
    public void delay()
    {
        dr.StartDialogue("Level2_win");
    }
    public void ChangeSprite(GameObject g, string name)
    {
        Sprite sp = Resources.Load<Sprite>(name);
        g.GetComponent<SpriteRenderer>().sprite = sp;
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
