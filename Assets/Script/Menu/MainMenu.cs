using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public GameObject main;
    bool show = false;
    public void pause()
    {
        main.SetActive(true);
        Time.timeScale = 0f;
    }
    public void back()
    {
        main.SetActive(false);
        Time.timeScale = 1f;
    }
    public void reload()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
