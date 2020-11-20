using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inDormir : inBase
{
    [FMODUnity.EventRef]
    public string CamaInt;
    FMOD.Studio.EventInstance eDormir;

    public float decressimo;

    public override void exclusivo()
    {
        GameStatus.nivelSuspeita -= decressimo;

        // Setar emiter do som
        eDormir = FMODUnity.RuntimeManager.CreateInstance(CamaInt);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(eDormir, GetComponent<Transform>(), GetComponent<Rigidbody>());

        // Play no som
        eDormir.start();

    }
}
