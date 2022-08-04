using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Portal : MonoBehaviour
{
    // 关卡管理器 通过其切换场景
    public GameObject levelmanager;
    // 是否是从现在到过去的传送
    public bool NowToPast = true;
    public bool isimmediate = false;

    bool onTrigger = false;

    void Update()
    {
        // 当玩家处于碰撞体内时 按键传送
        if (onTrigger)
        {
            if (isimmediate)
            {
                teleport();
            }
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                teleport();
            }
        }
    }

    void teleport()
    {
        if (NowToPast)
        {
            StartCoroutine(levelmanager.GetComponent<PortalManager>().switchToI());
            // levelmanager.GetComponent<PortalManager>().switchToI();
        }
        else
        {
            StartCoroutine(levelmanager.GetComponent<PortalManager>().switchToA());
            // levelmanager.GetComponent<PortalManager>().switchToA();
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
}
