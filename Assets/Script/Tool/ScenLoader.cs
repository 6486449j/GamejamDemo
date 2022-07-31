using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenLoader : MonoBehaviour
{
    public string loadSceneName;
    public bool isimmediate;

    bool onTrigger = false;

    void Start()
    {

    }

    void Update()
    {
        if (onTrigger)
        {
            if (isimmediate)
            {
                SceneManager.LoadScene(loadSceneName);
            }
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                SceneManager.LoadScene(loadSceneName);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            onTrigger = true;
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            onTrigger = false;
        }
    }
}
