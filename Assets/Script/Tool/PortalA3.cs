using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalA3 : MonoBehaviour
{
    public Camera mainCamera;
    public ProtalType protalType = ProtalType.Left;
    public GameObject distination;

    bool isOnTrigger = false;
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if (isOnTrigger)
        {
            if (protalType == ProtalType.Left)
            {
                player.transform.position = new Vector3(distination.transform.position.x + 5, distination.transform.position.y + 0.5f, 0);
                mainCamera.transform.position = new Vector3(distination.transform.position.x, distination.transform.position.y, -10);
            }

            if (protalType == ProtalType.Right)
            {
                player.transform.position = new Vector3(distination.transform.position.x - 5, distination.transform.position.y + 0.5f, 0);
                mainCamera.transform.position = new Vector3(distination.transform.position.x, distination.transform.position.y, -10);
            }
            if (protalType == ProtalType.Down && Input.GetKeyDown(KeyCode.DownArrow))
            {
                player.transform.position = new Vector3(distination.transform.position.x, distination.transform.position.y + 0.5f, 0);
                mainCamera.transform.position = new Vector3(distination.transform.position.x, distination.transform.position.y, -10);
            }
            if (protalType == ProtalType.Up && Input.GetKeyDown(KeyCode.UpArrow))
            {
                player.transform.position = new Vector3(distination.transform.position.x, distination.transform.position.y + 0.5f, 0);
                mainCamera.transform.position = new Vector3(distination.transform.position.x, distination.transform.position.y, -10);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            isOnTrigger = true;
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            isOnTrigger = false;
        }
    }
}

public enum ProtalType
{
    Left,
    Right,
    Up,
    Down
}