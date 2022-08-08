using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionWindow : MonoBehaviour
{
    public GameObject metaldoor;
    public GameObject exitdoor;
    bool onTrigger = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                metaldoor.SetActive(true);
                ChangeSprite(exitdoor, "Doubledoor_open");
                Level2.isRun = true;
            }
        }
    }
    public void ChangeSprite(GameObject g, string name)
    {
        Sprite sp = Resources.Load<Sprite>(name);
        g.GetComponent<SpriteRenderer>().sprite = sp;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            onTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            onTrigger = false;
        }
    }
}
