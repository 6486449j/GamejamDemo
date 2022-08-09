using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class EndPortal : MonoBehaviour
{
    DialogueRunner dr;
    Animator at;

    public GameObject player;
    public BoxCollider2D portal_des;
    public GameObject title;
    Vector2 v2;
    private void Awake()
    {
        dr = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
        dr.AddCommandHandler<GameObject>(
            "end",
            End
            );
        dr.AddCommandHandler<GameObject>(
            "stop",
            Stop
            );
        dr.AddCommandHandler<GameObject>(
            "anim",
            Anim
            );
    }
    private void Start()
    {
        v2 = portal_des.transform.position;
        at = GameObject.FindGameObjectWithTag("Cover").GetComponent<Animator>();
    }
    private void End(GameObject s)
    {
        //player.transform.position = v2;
        StartCoroutine(Go());
        player.transform.position = v2;
    }
    IEnumerator Go()
    {
        at.gameObject.SetActive(true);
        at.SetTrigger("Start");
        yield return new WaitForSeconds(0.5f);
        //player.transform.position = v2;
        A4BoundList.Instance.end();
        A4Bgm.Instance.initend();
        A4Bgm.Instance.PlaySound();
        at.SetTrigger("End");
        at.gameObject.SetActive(false);
        Invoke("Title", 2);
    }
    private void Stop(GameObject s)
    {
        player.SendMessage("Stop");
    }
    public void Title()
    {
        title.SetActive(true);
    }
    private void Anim(GameObject s)
    {

    }
}
