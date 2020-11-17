﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inPartitura : inBase
{
    [FMODUnity.EventRef]
    public string PartituraInt;
    FMOD.Studio.EventInstance eCifraClub; //sim eu fiz uma piadoca haha humor e piadas

    public GameObject partituraHUD;

    public bool partitura;

    public override void exclusivo()
    {
        if (partitura)
        {
            GameStatus.partituras++;
            partituraHUD.SetActive(true);
            GameStatus.PlayerMovement = false;
            partitura = false;
        }

        // Setar emiter do som
        eCifraClub = FMODUnity.RuntimeManager.CreateInstance(PartituraInt);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(eCifraClub, GetComponent<Transform>(), GetComponent<Rigidbody>());

        // Play no som
        eCifraClub.start();

    }
}
