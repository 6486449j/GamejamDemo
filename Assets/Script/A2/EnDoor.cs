using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnDoor : MonoBehaviour
{
    bool isin=false;
    void Update()
    {
        if (isin)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                A2BoundList.Instance.hospital();
                A2Bgm.Instance.initmain();
                A2Bgm.Instance.PlaySound();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isin = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isin = false;
    }
}
