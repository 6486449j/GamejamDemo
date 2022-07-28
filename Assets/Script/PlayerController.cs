using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 6;
    public int jumpscale = 10;
    public float jumpReserved = 0.1f;
    public BoxCollider2D footCollider;
    public GameObject flashLight;
    bool isLight = false;
    Rigidbody2D rgdBody;
    SpriteRenderer spRenderer;
    void Start()
    {
        rgdBody = gameObject.GetComponent<Rigidbody2D>();
        spRenderer = gameObject.GetComponent<SpriteRenderer>();
        flashLight.SetActive(false);
    }
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        if (move < 0)
        {
            spRenderer.flipY = true;
            flashLight.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (move > 0)
        {
            spRenderer.flipY = false;
            flashLight.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        rgdBody.velocity = new Vector2(move * speed, rgdBody.velocity.y);
        if (Input.GetButtonDown("Jump") && onGround())
        {
            transform.Translate(0, jumpscale * Time.deltaTime, 0);
            rgdBody.AddForce(new Vector2(0, jumpscale), ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (isLight==false) { 
                flashLight.SetActive(true);
                isLight = true;
            }
            else
            {
                flashLight.SetActive(false);
                isLight = false;
            }
        }
    }

    bool onGround()
    {
        return footCollider.IsTouchingLayers(~LayerMask.GetMask("Player"));
    }

}
