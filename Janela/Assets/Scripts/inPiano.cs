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

    public GameObject personagemSentado, transicao;
    public override void startCapsule()
    {
        distance = 2.2f;
    }

    public override void exclusivo()
    {
        transicao.SetActive(true);
        personagemSentado.SetActive(true);
        GameStatus.Player.gameObject.SetActive(false);
        GameStatus.tempo = -19;
        GameStatus.dia++;

        PianoMusic1 = FMODUnity.RuntimeManager.CreateInstance(firstPianoMusic);

        FMODUnity.RuntimeManager.AttachInstanceToGameObject(PianoMusic1, GetComponent<Transform>(), GetComponent<Rigidbody>());

        PianoMusic();



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
