using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class ContinueDialogue : MonoBehaviour
{
    LineView lv;

    // Start is called before the first frame update
    void Start()
    {
        lv = gameObject.GetComponent<LineView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            lv.OnContinueClicked();
        }
    }
}
