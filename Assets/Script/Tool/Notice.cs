using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notice : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject notice_;
    GameObject go;
    //public BoxCollider2D bc2d;

    void Start()
    {
        go = Instantiate(notice_);
        Vector2 v2 =new Vector2(transform.position.x, transform.position.y + 2f);
        go.transform.position = v2;
        go.SetActive(false);
        Debug.Log("success");
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
