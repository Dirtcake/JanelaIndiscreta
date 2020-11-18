using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class Transicao : MonoBehaviour
{

    private PlayableDirector director;

    public GameObject diaHUD;


    void Start()
    {
        director = transform.GetChild(0).GetComponent<PlayableDirector>();
        director.stopped += OnPlayableDirectorStopped;
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (director == aDirector)
        {

            diaHUD.transform.GetChild(GameStatus.dia).gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }


    void Update()
    {


        if (transform.GetChild(0).GetComponent<PlayableDirector>().time == transform.GetChild(0).GetComponent<PlayableDirector>().duration)
        {
            diaHUD.transform.GetChild(GameStatus.dia).gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        transform.GetChild(0).GetComponent<PlayableDirector>().Play();
    }
}
