using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    public static int dia;                  // Numero de dias

    public static float nivelSuspeita;        // Nivel de suspeita

    public static GameObject Player;
    public static GameObject cursores;
    public static GameObject interacaoHUD;
    public static GameObject FeedBackConclusao;
    public static GameObject HudOlhos;

    public static bool PlayerMovement = true;   // bool para travamento do movimento do personagem

    public static Image HUDSuspeita;
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
        HudOlhos = GameObject.Find("Olho_Suspeita");
        HUDSuspeita = GameObject.Find("Observado_Dano").GetComponent<Image>();
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

        #region Olhos de suspeita
        /*
         O nivel de suspeita trabalha com baseno Alpha da hud "Observado_Dano", 255 no maximo e cada nivel de suspeita é 85.
         */
        nivelSuspeita = Mathf.Clamp(nivelSuspeita + 0.05f * Time.deltaTime, 0, 1);

        Color c = HUDSuspeita.color;
        c.a = nivelSuspeita;
        HUDSuspeita.color = c;

        if (HUDSuspeita.color.a != 0f)
        {
            if (IsBetween(HUDSuspeita.color.a , 0f , 0.33f))
            {
                for (int i = 0; i < HudOlhos.transform.childCount; i++)
                {
                    if (i == 1) // Numero do indice que se quer ativado, o resto será desativado
                    {
                        HudOlhos.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    else HudOlhos.transform.GetChild(i).gameObject.SetActive(false);
                }
            }
            if (IsBetween(HUDSuspeita.color.a, 0.33f, 0.66f))
            {
                for (int i = 0; i < HudOlhos.transform.childCount; i++)
                {
                    if (i == 2) // Numero do indice que se quer ativado, o resto será desativado
                    {
                        HudOlhos.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    else HudOlhos.transform.GetChild(i).gameObject.SetActive(false);
                }
            }
            if (IsBetween(HUDSuspeita.color.a, 0.66f, 1f))
            {
                for (int i = 0; i < HudOlhos.transform.childCount; i++)
                {
                    if (i == 3) // Numero do indice que se quer ativado, o resto será desativado
                    {
                        HudOlhos.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    else HudOlhos.transform.GetChild(i).gameObject.SetActive(false);
                }
            }
        }
        else for (int i = 0; i > HudOlhos.transform.childCount; i++)
            {
                if (i == 0) // Numero do indice que se quer ativado, o resto será desativado
                {
                    HudOlhos.transform.GetChild(i).gameObject.SetActive(true);
                }
                else HudOlhos.transform.GetChild(i).gameObject.SetActive(false);
            }
        #endregion
    }

    public void restartScene()
    {
        SceneManager.LoadScene("Game");

        FMOD.Studio.PLAYBACK_STATE fmodPlayback;
        PianoMusic1.getPlaybackState(out fmodPlayback);

        if (fmodPlayback == FMOD.Studio.PLAYBACK_STATE.PLAYING)
        {
            PianoMusic1.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        }

        
    }


    // Utilitarios
    public bool IsBetween(float p, float minValue, float maxValue)
    {
        if (minValue > maxValue) return false;
        return p > minValue && p < maxValue;
    }

}
