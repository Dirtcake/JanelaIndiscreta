using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inTutorial : inBase
{
    public GameObject tutorial;
    public override void startCapsule()
    {
    }

    public override void updateCapsule()
    {
    }

    public override void exclusivo()
    {
        tutorial.SetActive(true);
        GameStatus.PlayerMovement = false;
    }
}
