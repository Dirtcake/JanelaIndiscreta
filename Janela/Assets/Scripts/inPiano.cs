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

        PianoMusic1.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);

        FMODUnity.RuntimeManager.AttachInstanceToGameObject(PianoMusic1, GetComponent<Transform>(), GetComponent<Rigidbody>());
    }

    void Update()
    {
        FMOD.Studio.PLAYBACK_STATE fmodPlayback;
        PianoMusic1.getPlaybackState(out fmodPlayback);

        if (fmodPlayback == FMOD.Studio.PLAYBACK_STATE.STOPPED && isMusicPlaying == true)
        {
            isMusicPlaying = false;
            PianoMusic1.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        }
    }

    public override void exclusivo()
    {
        FMOD.Studio.PLAYBACK_STATE fmodPlayback;
        PianoMusic1.getPlaybackState(out fmodPlayback);

        // aparece o assasino e o observador

        if (GameStatus.assasino == true && GameStatus.pista == true )
        {
            if (fmodPlayback != FMOD.Studio.PLAYBACK_STATE.PLAYING && isMusicPlaying == false)
            {
                isMusicPlaying = true;
                PianoMusic1.start();
            }

            perdestes.SetActive(true);
            Time.timeScale = 0;

        }

        else if (GameStatus.assasino == false && GameStatus.pista == true && GameStatus.observador == true)
        {
            if (fmodPlayback == FMOD.Studio.PLAYBACK_STATE.STOPPED && isMusicPlaying == false)
            {
                isMusicPlaying = true;
                PianoMusic1.start();
            }

            ganhastes.SetActive(true);
            Time.timeScale = 0;
        }

        assasino.SetActive(true);
        observador.SetActive(true);

        GameStatus.assasino = true;
        GameStatus.observador = true;

    }
}
