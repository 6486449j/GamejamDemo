using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using Yarn.Unity;

public class Exit : MonoBehaviour
{
    public GameObject light_;

    Light2D lights;
    public float intensity = 0.15f;

    bool onTrigger = false;
    public BoxCollider2D portal_local;
    public BoxCollider2D portal_des;

    public GameObject Player;
    Vector2 v2;

    DialogueRunner dr;

    void Start()
    {
        v2 = portal_des.transform.position;
        lights = light_.GetComponent<Light2D>();
        dr = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
    }
    void Update()
    {
        if (onTrigger)
        {
            if (Level2.isRun == true)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    A2Bgm.Instance.initenter();
                    A2Bgm.Instance.PlaySound();
                    A2SoundManager.Instance.initdoor();
                    A2SoundManager.Instance.PlaySound();
                    A2BoundList.Instance.exit();
                    A2Footstep.Instance.initgrass();
                    Player.transform.position = v2;
                    light_.SetActive(true);
                    lights.intensity = intensity;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    dr.StartDialogue("Level2_exit");
                }
            }
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
