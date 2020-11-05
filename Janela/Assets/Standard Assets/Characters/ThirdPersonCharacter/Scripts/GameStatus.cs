using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string firstPianoMusic;
    FMOD.Studio.EventInstance PianoMusic1;


    public static bool pista = false;       // J1
    public static bool assasino = true;     // J1
    public static bool observador;          // J1

    public static string targetAction;      // Nome da ação a ser executada

    public static int tempo;                // Tempo do jogo, em segundos
    public static int partituras;           // Numero de partituras do jogador
    public static int nivelSuspeita;        // Nivel de suspeita

    public static GameObject Player;
    public static GameObject cursores;
    public static GameObject interacaoHUD;
    public static GameObject FeedBackConclusao;

    

    public static bool PlayerMovement = true;   // bool para travamento do movimento do personagem
    void Start()
    {
        FeedBackConclusao = GameObject.Find("FeedBackConclusao");
        FeedBackConclusao.SetActive(false);

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
        #region Cursores
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
        #endregion
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
