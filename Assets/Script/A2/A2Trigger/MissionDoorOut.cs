using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionDoorOut : MonoBehaviour
{
    bool onTrigger = false;
    public Animator anim;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                A2BoundList.Instance.mission();
                A2SoundManager.Instance.initdoor();
                A2SoundManager.Instance.PlaySound();
            }
            /*if(Level2.isRun = true){
                anim.SetBool("isTrigger", true);
            }*/
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
