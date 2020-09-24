using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string firstPianoMusic;
    FMOD.Studio.EventInstance PianoMusic1;


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
        FMOD.Studio.PLAYBACK_STATE fmodPlayback;
        PianoMusic1.getPlaybackState(out fmodPlayback);

        if (fmodPlayback == FMOD.Studio.PLAYBACK_STATE.PLAYING)
        {
            PianoMusic1.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        }

        SceneManager.LoadScene("Game");
    }
}
