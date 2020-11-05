using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;

public class inPiano : inBase
{
    [FMODUnity.EventRef]
    public string firstPianoMusic;
    FMOD.Studio.EventInstance PianoMusic1;

    public GameObject assasino, observador,perdestes, ganhastes;
    public bool isMusicPlaying = false;

    /* void Start()
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
     }*/

    public override void startCapsule()
    {
        distance = 2.2f;
    }

    public override void exclusivo()
    {
        PianoMusic1 = FMODUnity.RuntimeManager.CreateInstance(firstPianoMusic);

        FMODUnity.RuntimeManager.AttachInstanceToGameObject(PianoMusic1, GetComponent<Transform>(), GetComponent<Rigidbody>());     

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

    public class FmodExtensions
    {
        public static bool IsPlaying(FMOD.Studio.EventInstance instance)
        {
            FMOD.Studio.PLAYBACK_STATE state;
            instance.getPlaybackState(out state);
            return state != FMOD.Studio.PLAYBACK_STATE.STOPPED;
        }
    }

    void PianoMusic()
    {
        if (isMusicPlaying == false)
        {
            PianoMusic1.start();
            isMusicPlaying = true;
        }
        else if (isMusicPlaying == true && FmodExtensions.IsPlaying(PianoMusic1)) isMusicPlaying = false;
    }
}
