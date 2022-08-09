using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class HiggsTr : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    DialogueRunner dr;
    void Start()
    {
        dr = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //dr.StartDialogue("Level2_higgs");
            Invoke("fade", 2);
        }
    }
    public void fade()
    {
        anim.SetBool("isTrigger", true);
    }
}
