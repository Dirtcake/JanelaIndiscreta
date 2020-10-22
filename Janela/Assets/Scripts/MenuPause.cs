using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menupause : MonoBehaviour
{
    public GameObject Menupause;

    public static bool isPaused;
  
    void Start()
    {
        Menupause.SetActive(false);
    }

 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Menupause.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        Menupause.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}

