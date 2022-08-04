using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class A1Door : MonoBehaviour
{
    // Start is called before the first frame update
    bool isondoor=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isondoor)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                A1SoundManager.Instance.intiOpenDoor();
                A1SoundManager.Instance.PlaySound();
                Invoke("next", 2);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isondoor = true;
    }
    public void next()
    {
        A1bgm.Instance.stopbgm2();
        SceneManager.LoadScene("Level_2");
    }
}
