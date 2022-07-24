using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject apperance;
    public GameObject _internal;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            portal1();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            portal2();
        }
    }

    public void portal1()
    {
        _internal.SetActive(false);
        apperance.SetActive(true);
    }
    public void portal2()
    {

        apperance.SetActive(false);
        _internal.SetActive(true);
    }
}
