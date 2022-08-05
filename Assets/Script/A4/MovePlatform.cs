using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public Vector3 point1 = new Vector3(0, 0);
    public Vector3 point2 = new Vector3(0, 0);
    public float speed = 2;

    Rigidbody2D rgd;
    bool moveback = false;

    void Start()
    {
        rgd = gameObject.GetComponent<Rigidbody2D>();
    }

    // void Update()
    // {
    //     // rgd.MovePosition(point2);
    //     if ((transform.position - point1).x < 0)
    //     {
    //         moveback = false;
    //     }
    //     if (positionClose(transform.position, point2))
    //     {
    //         moveback = true;
    //     }
    //     if (!positionClose(transform.position, point2) && !moveback)
    //     {
    //         rgd.MovePosition(transform.position + (point2 - point1).normalized * speed * Time.deltaTime);
    //         // transform.Translate((point2 - transform.position).normalized * Time.deltaTime * speed);
    //     }
    //     else if (!positionClose(transform.position, point1) && moveback)
    //     {
    //         rgd.MovePosition(transform.position + (point1 - point2).normalized * speed * Time.deltaTime);
    //         // transform.Translate((point1 - transform.position).normalized * Time.deltaTime * speed);
    //     }
    // }

    void FixedUpdate()
    {
        // float sin = Mathf.Sin(Time.time - Mathf.PI / 2) * 0.5f + 0.5f;
        float sin = Mathf.Sin(Time.time);
        Debug.Log(sin);


    }

    bool positionClose(Vector3 pos1, Vector3 pos2)
    {
        return (pos2 - pos1).magnitude < 0.01;
    }
}
