using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HosDoorIn : MonoBehaviour
{
    // Start is called before the first frame update
    bool isin = false;
    void Update()
    {
        if (isin)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                A2BoundList.Instance.hospital();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isin = true;
    }

}
