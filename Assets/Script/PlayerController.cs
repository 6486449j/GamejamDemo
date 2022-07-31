using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour
{
    // 移动速度
    public int speed = 6;
    // 跳跃力度
    public int jumpscale = 10;

    // 玩家底部的碰撞器 用于检测玩家是否处于地面
    public BoxCollider2D footCollider;
    // 手电筒
    public GameObject flashLight;
    bool isLight = false;
    BoxCollider2D collider2d;
    Rigidbody2D rgdBody;
    SpriteRenderer spRenderer;


    void Start()
    {
        rgdBody = gameObject.GetComponent<Rigidbody2D>();
        spRenderer = gameObject.GetComponent<SpriteRenderer>();
        collider2d = gameObject.GetComponent<BoxCollider2D>();
        flashLight.SetActive(false);
    }
    void Update()
    {
        // 翻转角色
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

        // 跳跃
        rgdBody.velocity = new Vector2(move * speed, rgdBody.velocity.y);
        if (Input.GetButtonDown("Jump") && onGround())
        {
            // transform.Translate(0, jumpscale * Time.deltaTime, 0);
            rgdBody.AddForce(new Vector2(0, jumpscale), ForceMode2D.Impulse);
        }

        // 开关手电筒
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (isLight == false)
            {
                flashLight.SetActive(true);
                isLight = true;
            }
            else
            {
                flashLight.SetActive(false);
                isLight = false;
            }
        }
        // 传送
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (collider2d.IsTouchingLayers(LayerMask.GetMask("PortalToPast")))
            {

            }
            if (collider2d.IsTouchingLayers(LayerMask.GetMask("PortalToNow")))
            {

            }
        }
    }

    bool onGround()
    {
        return footCollider.IsTouchingLayers(~LayerMask.GetMask("Player"));
    }
}
