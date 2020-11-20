using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inBanho : inBase
{
    [FMODUnity.EventRef]
    public string BanhoInt;
    FMOD.Studio.EventInstance eBath;

    public float decressimo;

    public override void exclusivo()
    {
        GameStatus.nivelSuspeita -= decressimo;

        // Setar emiter do som
        eBath = FMODUnity.RuntimeManager.CreateInstance(BanhoInt);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(eBath, GetComponent<Transform>(), GetComponent<Rigidbody>());

        // Play no som
        eBath.start();
    }
}
