using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public Vector3 point1 = new Vector3(0, 0);
    public Vector3 point2 = new Vector3(0, 0);
    public float speed = 2;

    bool moveback = false;
    bool playerOnPlatform = false;
    Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (positionClose(transform.position, point1))
            moveback = false;
        if (positionClose(transform.position, point2))
            moveback = true;
        if (moveback)
        {
            transform.Translate((point1 - transform.position).normalized * speed * Time.deltaTime);
            if (playerOnPlatform)
                player.Translate((point1 - transform.position).normalized * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate((point2 - transform.position).normalized * speed * Time.deltaTime);
            if (playerOnPlatform)
                player.Translate((point2 - transform.position).normalized * speed * Time.deltaTime);
        }

    }


    bool positionClose(Vector3 pos1, Vector3 pos2)
    {
        return (pos2 - pos1).magnitude < 0.05;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("CollisionEnter");
            playerOnPlatform = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("CollisionExit");
            playerOnPlatform = false;
        }
    }
}
