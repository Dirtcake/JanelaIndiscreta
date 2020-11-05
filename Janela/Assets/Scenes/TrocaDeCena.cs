using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class TrocaDeCena : MonoBehaviour
{
    public VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
    public string SceneName;

    public Image myPanel; //imagem de "pressione ~botão~ para pular"
    public float fadeTime = 2f;
    Color colorToFadeTo;
    Color DefaultColor;

    void Start()
    {
        //Trocar de cena quando acabar a cutscene
        VideoPlayer.loopPointReached += LoadScene;

        //Cores do botão de pular
        colorToFadeTo = new Color(1f, 1f, 1f, 0f);
        DefaultColor = new Color(1f, 1f, 1f, 1f);

        myPanel.CrossFadeColor(colorToFadeTo, fadeTime, true, true);
    }

    void Update()
    {

        //Detectar qualquer tecla e mostrar o botão de pular
        if (Input.anyKeyDown)
        {

            myPanel.CrossFadeColor(DefaultColor, 0f, true, true);
            myPanel.CrossFadeColor(colorToFadeTo, fadeTime, true, true);
        }

        //Pular a cs
        if (Input.GetKeyDown("tab"))
        {
            SceneManager.LoadScene(SceneName);
        }
    }

    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(SceneName);
    }
}
