using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class Transicao : MonoBehaviour
{

    private PlayableDirector director;

    public GameObject diaHUD;
    public GameObject CanvasPrincipal;
    public GameObject PersSentado, PersOriginal;

    private void Awake()
    {
        diaHUD.transform.GetChild(GameStatus.dia).gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

    void Start()
    {
        director = transform.GetChild(0).GetComponent<PlayableDirector>();
    }



    void Update()
    {


        if (transform.GetChild(0).GetComponent<PlayableDirector>().time == transform.GetChild(0).GetComponent<PlayableDirector>().duration)
        {
            PartituraSistem.on = true;

            CanvasPrincipal.SetActive(true);

            PersSentado.SetActive(false);
            PersOriginal.SetActive(true);
            diaHUD.transform.GetChild(GameStatus.dia).gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            CanvasPrincipal.SetActive(false);
        }
    }

    private void OnEnable()
    {
        transform.GetChild(0).GetComponent<PlayableDirector>().Play();
    }
}
