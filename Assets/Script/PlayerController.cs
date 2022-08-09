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

    public Animator anim;

    bool isLight = false;
    bool isCollsion = false;
    bool isBan = false;
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
            spRenderer.flipX = true;
            
            flashLight.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (move > 0)
        {
            spRenderer.flipX = false;
            flashLight.transform.rotation = Quaternion.Euler(0, 0, -90);
        }

        if (rgdBody.velocity.y < 0.001)
        {
            footCollider.gameObject.SetActive(true);
        }
        else
        {
            footCollider.gameObject.SetActive(false);
        }

        if (Mathf.Abs(rgdBody.velocity.x) > 0.1f)
        {
            anim.SetBool("isRun", true);
        }
        else
        {
            anim.SetBool("isRun", false);
        }

        if (isCollsion)
        {
            rgdBody.velocity = new Vector2(0, rgdBody.velocity.y);
        }
        // 跳跃
        rgdBody.velocity = new Vector2(move * speed, rgdBody.velocity.y);
        // rgdBody.MovePosition(new Vector2(move * speed, 0));
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
                anim.SetBool("isFlash", true);
            }
            else
            {
                flashLight.SetActive(false);
                isLight = false;
                anim.SetBool("isFlash", false);
            }
        }

        if (isBan == true)
        {
            rgdBody.Sleep();
        }
        else
        {
            rgdBody.IsAwake();
        }
    }
    public void Stop()
    {
        rgdBody.Sleep();
    }
    public void cont()
    {
        rgdBody.IsAwake();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isCollsion = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isCollsion = false;
    }

    bool onGround()
    {
        return footCollider.IsTouchingLayers(~LayerMask.GetMask("Player", "ViewBound", "IgnoreCollision"));
    }
}
