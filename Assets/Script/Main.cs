using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cam;
    // public BoxCollider2D de;
    //public BoxCollider2D thus;

    Vector3 v2s;
    Vector3 v2r;
    Vector3 thisv;

    void Start()
    {
        // v2s = de.transform.position;
        //v2r = thus.transform.position;
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
        Vector3 v3c = new Vector3(this.transform.position.x, this.transform.position.y, 30);
        this.transform.position = v3c;
        Vector3 v3c1 = new Vector3(this.transform.position.x, 0, 15);
        cam.transform.position = v3c1;
    }
    public void portal2()
    {
        Vector3 v3c = new Vector3(this.transform.position.x, this.transform.position.y, 0);
        this.transform.position = v3c;
        Vector3 v3c1 = new Vector3(this.transform.position.x, 0, -10);
        cam.transform.position = v3c1;
    }
}
