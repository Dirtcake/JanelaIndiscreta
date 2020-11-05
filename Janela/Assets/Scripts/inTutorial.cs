using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inTutorial : inBase
{
    [FMODUnity.EventRef]
    public string TutorialInt;
    FMOD.Studio.EventInstance eTut;

    public GameObject tutorial;
    public override void startCapsule()
    {
    }

    public override void updateCapsule()
    {
    }

    public override void exclusivo()
    {
        // Setar emiter do som
        eTut = FMODUnity.RuntimeManager.CreateInstance(TutorialInt);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(eTut, GetComponent<Transform>(), GetComponent<Rigidbody>());

        // Play no som
        eTut.start();

        tutorial.SetActive(true);
        GameStatus.PlayerMovement = false;
    }
}
