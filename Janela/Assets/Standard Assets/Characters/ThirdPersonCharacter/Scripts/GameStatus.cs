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

    public static string targetAction;

    public static GameObject Player;

    public static int tempo;

    public static GameObject cursores;
    public static GameObject interacaoHUD;
    void Start()
    {
        Cursor.visible = false;

        pista = false;
        assasino = true;
        observador = false;
        Time.timeScale = 1;

        Player = GameObject.Find("Player");
        interacaoHUD = GameObject.Find("Interacoes");
        cursores = GameObject.Find("Cursores");

    }

    void Update()
    {
        cursores.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        interacaoHUD.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);


        if (Input.GetMouseButton(0))
        {
            cursores.transform.GetChild(1).gameObject.SetActive(true);
            cursores.transform.GetChild(0).gameObject.SetActive(false);

        }
        else
        {
            cursores.transform.GetChild(1).gameObject.SetActive(false);
            cursores.transform.GetChild(0).gameObject.SetActive(true);
        }
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
