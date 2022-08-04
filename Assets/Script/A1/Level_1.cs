using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1 : MonoBehaviour
{

    // BoxCollider2D collider2d;
    PortalManager pm;

    void Start()
    {
        // collider2d = gameObject.GetComponent<BoxCollider2D>();
        pm = gameObject.GetComponent<PortalManager>();

        // pm._internal.SetActive(false);
        pm._internal.SetActive(false);

        A1bgm.Instance.playbgm1();
    }

    void Update()
    {
    }
}
