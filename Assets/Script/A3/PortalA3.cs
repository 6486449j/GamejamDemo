using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalA3 : MonoBehaviour
{
    public Camera mainCamera;
    public ProtalType protalType = ProtalType.Left;
    public GameObject distination;

    Animator at;

    bool isOnTrigger = false;
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");

        at = GameObject.Find("Cover").GetComponent<Animator>();
    }

    void Update()
    {
        if (isOnTrigger)
        {
            if (protalType == ProtalType.Left)
            {
                StartCoroutine(L());
            }
            if (protalType == ProtalType.Right)
            {
                StartCoroutine(R());
            }
            if (protalType == ProtalType.Down && Input.GetKeyDown(KeyCode.DownArrow))
            {
                StartCoroutine(D());
            }
            if (protalType == ProtalType.Up && Input.GetKeyDown(KeyCode.UpArrow))
            {
                StartCoroutine(U());
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
    IEnumerator L()
    {
        at.gameObject.SetActive(true);
        at.SetTrigger("Start");
        yield return new WaitForSeconds(0.5f);
        player.transform.position = new Vector3(distination.transform.position.x + 5, distination.transform.position.y + 0.5f, 0);
        mainCamera.transform.position = new Vector3(distination.transform.position.x, distination.transform.position.y, -10);
        at.SetTrigger("End");
        at.gameObject.SetActive(false);
    }

    IEnumerator R()
    {

        at.gameObject.SetActive(true);
        at.SetTrigger("Start");
        yield return new WaitForSeconds(0.5f);
        player.transform.position = new Vector3(distination.transform.position.x - 5, distination.transform.position.y + 0.5f, 0);
        mainCamera.transform.position = new Vector3(distination.transform.position.x, distination.transform.position.y, -10);
        at.SetTrigger("End");
        at.gameObject.SetActive(false);
    }

    IEnumerator U()
    {

        at.gameObject.SetActive(true);
        at.SetTrigger("Start");
        yield return new WaitForSeconds(0.5f);
        player.transform.position = new Vector3(distination.transform.position.x, distination.transform.position.y + 0.5f, 0);
        mainCamera.transform.position = new Vector3(distination.transform.position.x, distination.transform.position.y, -10);
        at.SetTrigger("End");
        at.gameObject.SetActive(false);
    }

    IEnumerator D()
    {
        at.gameObject.SetActive(true);
        at.SetTrigger("Start");
        yield return new WaitForSeconds(0.5f);
        player.transform.position = new Vector3(distination.transform.position.x, distination.transform.position.y + 0.5f, 0);
        mainCamera.transform.position = new Vector3(distination.transform.position.x, distination.transform.position.y, -10);
        at.SetTrigger("End");
        at.gameObject.SetActive(false);
    }
}


public enum ProtalType
{
    Left,
    Right,
    Up,
    Down
}