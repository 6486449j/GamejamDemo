using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 6;
    public int jumpscal = 10;
    Rigidbody2D rgdBody;
    BoxCollider2D selfCollider;
    public float raycastLenght = 1;
    void Start()
    {
        rgdBody = gameObject.GetComponent<Rigidbody2D>();
        selfCollider = gameObject.GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rgdBody.velocity = new Vector2(move * speed, rgdBody.velocity.y);
        if (Input.GetButtonDown("Jump") && onGround())
        {
            transform.Translate(0, jumpscal * Time.deltaTime, 0);
            rgdBody.AddForce(new Vector2(0, jumpscal), ForceMode2D.Impulse);
        }
        Debug.DrawLine(new Vector3(transform.position.x, transform.position.y, 0), new Vector3(transform.position.x, transform.position.y - raycastLenght, 0), Color.red);
    }

    bool onGround()
    {
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), new Vector2(transform.position.x, transform.position.y - 1), raycastLenght, ~LayerMask.GetMask("Player"));
        // if (hit.centroid != null) Debug.Log(hit.collider.name);
        return (hit.collider != null);
    }
}
