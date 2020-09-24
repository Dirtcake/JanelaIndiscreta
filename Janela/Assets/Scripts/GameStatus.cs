using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    public static bool pista = false;

    public static bool assasino = true;
    public static bool observador;
    void Start()
    {
        pista = false;
        assasino = true;
        observador = false;
        Time.timeScale = 1;
    }

    void Update()
    {
        
    }

    public void restartScene()
    {
        SceneManager.LoadScene("Game");
    }
}
