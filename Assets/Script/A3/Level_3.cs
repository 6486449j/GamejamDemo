using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_3 : MonoBehaviour
{
    public bool getkey = false;
    public GameObject cm;

    // Start is called before the first frame update
    void Start()
    {
        A3Bgm.Instance.initbgm();
        A3Bgm.Instance.PlaySound();
        cm.transform.position = new Vector3(1, 1, -10);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
