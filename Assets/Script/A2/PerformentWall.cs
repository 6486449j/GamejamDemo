using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformentWall : MonoBehaviour
{
    public GameObject BloodWall;  // 7
    public GameObject GhostWall;  // 19
    public GameObject Player;

    public float Bloodspeed = 0.1f;
    public float Ghostspeed = 1f;

    void Update()
    {
        if (Level2.isOutdoor)
        {
            if (BloodWall.transform.position.y >= 2)
            {
                BloodWall.transform.Translate(0, -Bloodspeed * Time.deltaTime, 0);
            }
            if(GhostWall.transform.position.y <= 19)
            {
                GhostWall.transform.Translate(Ghostspeed * Time.deltaTime, 0, 0);
            }
        }
    }
    void resetpos()
    {
        BloodWall.transform.position = new Vector2(-1.5f,7);
        GhostWall.transform.position = new Vector2(-33,2.5f);
        Player.transform.position = new Vector2(-15, 3);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            resetpos();
        }
    }
}
