using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;
    public GameObject HamburgerUI;

    void Start ()
    {
      PauseMenuUI.SetActive(false);
      HamburgerUI.SetActive(true);
      Time.timeScale = 1f;
      GameIsPaused = false;
      AudioListener.pause = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          if (GameIsPaused)
          {
            Resume();
          } else
          {
            Pause();
          }
        }
    }

    public void Resume ()
    {
      PauseMenuUI.SetActive(false);
      HamburgerUI.SetActive(true);
      Time.timeScale = 1f;
      GameIsPaused = false;
      AudioListener.pause = false;
    }

    public void Pause ()
    {
      PauseMenuUI.SetActive(true);
      HamburgerUI.SetActive(false);
      Time.timeScale = 0f;
      GameIsPaused = true;
      AudioListener.pause = true;
    }

    public void LoadMenu()
    {
      SceneManager.LoadScene(0);
    }

    public void LoadBack()
    {
      SceneManager.LoadScene(3);
    }
}
