using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inLavarLouca : inBase
{
    [FMODUnity.EventRef]
    public string LoucaInt;
    FMOD.Studio.EventInstance eSink;

    public float decressimo;

    public override void exclusivo()
    {
        GameStatus.nivelSuspeita -= decressimo;

        // Setar emiter do som
        eSink = FMODUnity.RuntimeManager.CreateInstance(LoucaInt);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(eSink, GetComponent<Transform>(), GetComponent<Rigidbody>());

        // Play no som, ta arrumado pra quando for colocar tempo da ação
        PlayTimedEvent();
    }

    void PlayTimedEvent()
    {
        eSink.setParameterByName("OpenFaucet", 0);
        eSink.start();    
    }
}
