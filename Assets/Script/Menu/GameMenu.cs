using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public GameObject menu;
    bool open=false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (open == false)
            {
                menu.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("esc");
                open = true;
            }
            else
            {
                menu.SetActive(false);
                Time.timeScale = 1f;
                Debug.Log("esc");
                open = false;
            }
        }
    }
}
