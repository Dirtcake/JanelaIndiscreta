using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inJanela : inBase
{
    public GameObject JanelaCam;
    public override void startCapsule()
    {
        distance = 2;
    }

    public override void updateCapsule()
    {
    }
    public override void exclusivo()
    {
        JanelaCam.SetActive(true);
    }
}
