using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionDoorIn : MonoBehaviour
{
    public GameObject missionroomout;
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
                A2BoundList.Instance.hospital();
                A2SoundManager.Instance.initdoor();
                A2SoundManager.Instance.PlaySound();
                Level2.isOutdoor = true;
                //Destroy(this.gameObject);
                missionroomout.SetActive(false);
                A2Bgm.Instance.initchase();
                A2Bgm.Instance.PlaySound();
            }
        }
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
