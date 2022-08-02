using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notice : MonoBehaviour
{
    public GameObject notice_;
    public Vector2 posOffset = new Vector2(0, 2);
    GameObject go;
    //public BoxCollider2D bc2d;

    void Start()
    {
        go = Instantiate(notice_);
        Vector2 v2 = new Vector2(transform.position.x + posOffset.x, transform.position.y + posOffset.y);
        go.transform.position = v2;
        go.SetActive(false);
        // Debug.Log("success");
    }

    // Update is called once per frame
    void Update()
    {
        //go.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        go.SetActive(true);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        go.SetActive(false);
    }
}
