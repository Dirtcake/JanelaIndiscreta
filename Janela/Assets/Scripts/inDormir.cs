using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inDormir : inBase
{
    [FMODUnity.EventRef]
    public string CamaInt;
    FMOD.Studio.EventInstance eDormir;

    public GameObject assasino;

    public override void exclusivo()
    {
        // Tirar assasino
        assasino.SetActive(false);
        GameStatus.assasino = false;

        // Setar emiter do som
        eDormir = FMODUnity.RuntimeManager.CreateInstance(CamaInt);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(eDormir, GetComponent<Transform>(), GetComponent<Rigidbody>());

        // Play no som
        eDormir.start();

    }
}
