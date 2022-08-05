using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class HosDoorOut : MonoBehaviour
{
    // Start is called before the first frame update

    bool isin = false;
    void Update()
    {
        if (isin)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                A2BoundList.Instance.assult();
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
