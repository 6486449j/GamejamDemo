using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 6;
    public int jumpscale = 10;
    public BoxCollider2D footCollider;
    Rigidbody2D rgdBody;
    // float raycastLenght = 1.1f;
    void Start()
    {
        rgdBody = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rgdBody.velocity = new Vector2(move * speed, rgdBody.velocity.y);
        if (Input.GetButtonDown("Jump") && onGround())
        {
            transform.Translate(0, jumpscale * Time.deltaTime, 0);
            rgdBody.AddForce(new Vector2(0, jumpscale), ForceMode2D.Impulse);
        }
        // Debug.DrawLine(new Vector3(transform.position.x, transform.position.y, 0), new Vector3(transform.position.x, transform.position.y - raycastLenght, 0), Color.red);
    }

    bool onGround()
    {
        // RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), new Vector2(0, -1), raycastLenght, ~LayerMask.GetMask("Player"));
        // if (hit.collider != null) Debug.Log(hit.collider.name);
        // return (hit.collider != null);
        return footCollider.IsTouchingLayers(~LayerMask.GetMask("Player"));
    }
}
