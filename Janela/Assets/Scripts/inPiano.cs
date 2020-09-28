using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inPiano : inBase
{
    [FMODUnity.EventRef]
    public string firstPianoMusic;
    FMOD.Studio.EventInstance PianoMusic1;

    public GameObject assasino, observador,perdestes, ganhastes;
    public bool isMusicPlaying = false;

    void Start()
    {
        PianoMusic1 = FMODUnity.RuntimeManager.CreateInstance(firstPianoMusic);

        FMODUnity.RuntimeManager.AttachInstanceToGameObject(PianoMusic1, GetComponent<Transform>(), GetComponent<Rigidbody>());

        if (isMusicPlaying == true)
        {
            PianoMusic();
        }
    }

    void Update()
    {
        //FMOD.Studio.PLAYBACK_STATE fmodPlayback;
        //PianoMusic1.getPlaybackState(out fmodPlayback);
    }

    public override void exclusivo()
    {
        //FMOD.Studio.PLAYBACK_STATE fmodPlayback;
        //PianoMusic1.getPlaybackState(out fmodPlayback);

        // aparece o assasino e o observador

        if (GameStatus.assasino == true && GameStatus.pista == true )
        {

            perdestes.SetActive(true);
            Time.timeScale = 0;

            PianoMusic();

        }

        else if (GameStatus.assasino == false && GameStatus.pista == true && GameStatus.observador == true)
        {

            ganhastes.SetActive(true);
            Time.timeScale = 0;

            PianoMusic();

        }

        assasino.SetActive(true);
        observador.SetActive(true);

        GameStatus.assasino = true;
        GameStatus.observador = true;

    }

    void PianoMusic()
    {
        if (isMusicPlaying == true)
        {
            PianoMusic1.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
            isMusicPlaying = false;
        }
        else if (isMusicPlaying == false)
        {
            PianoMusic1.start();
            isMusicPlaying = true;
        }
    }
}
