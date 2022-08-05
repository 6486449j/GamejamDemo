using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject floor1;
    public GameObject floor2;

    static public bool getpre1 = false;
    static public bool getpre2 = false;

    static public bool drug1 = false;
    static public bool drug2 = false;
    static public bool drug3 = false;

    static public bool isFinish = false;

    public BoxCollider2D drug1box;
    public BoxCollider2D drug2box;
    public BoxCollider2D drug3box;

    void Start()
    {
        floor2.SetActive(false);
        drug1box.enabled = false;
        drug2box.enabled = false;
        drug3box.enabled = false;
        A2Bgm.Instance.initenter();
        A2Bgm.Instance.PlaySound();
    }

    // Update is called once per frame
    void Update()
    {
        if(getpre1 && getpre2 == true)
        {
            if (drug1==false) drug1box.enabled = true;
            if (drug2==false) drug2box.enabled = true;
            if (drug3==false) drug3box.enabled = true;

        }
        if(drug3 && drug2 && drug1 == true)
        {
            isFinish = true;
        }
    }
}
