using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PastHosDoorOut : MonoBehaviour
{
    bool isin = false;
    void Update()
    {
        if (isin)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                A2BoundList.Instance.room();
                A2SoundManager.Instance.initdoor();
                A2SoundManager.Instance.PlaySound();
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
