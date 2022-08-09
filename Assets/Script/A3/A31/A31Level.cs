using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A31Level : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        A31Bgm.Instance.initbgm();
        A31Bgm.Instance.PlaySound();
        //Debug.Log("why");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
