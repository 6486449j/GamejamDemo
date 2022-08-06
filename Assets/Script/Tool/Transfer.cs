using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transfer : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider2D portal_local;
    public BoxCollider2D portal_des;
    // public GameObject notice;
    public GameObject Player;
    //public bool Auto = false;

    Vector2 v2;
    // GameObject notice_;
    bool isin;

    void Start()
    {
        v2 = portal_des.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isin)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Player.transform.position = v2;
                //PlayerState.Instance.setIdle();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //if(Auto)PlayerState.Instance.setPlayerV2(v2);
            Vector2 v21 = new Vector2(transform.position.x, transform.position.y);
            // notice_ = Instantiate(notice);
            // notice_.transform.position = v21;
            isin = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isin = false;
            // Destroy(notice_.gameObject);
        }
    }
}
