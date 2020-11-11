using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public static bool JogoPausado = false;

    public GameObject menuPauseUI;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (JogoPausado)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume ()
    {
        menuPauseUI.SetActive(false);
        Time.timeScale = 1f;
        JogoPausado = false;
    }

    void Pause ()
    {
        menuPauseUI.SetActive(true);
        Time.timeScale = 0f;
        JogoPausado = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("menu");
    }

}
