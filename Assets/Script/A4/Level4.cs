using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lights;
    void Start()
    {
        A4Bgm.Instance.initenter();
        A4Bgm.Instance.PlaySound();
        lights.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
