using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inDormir : inBase
{
    public GameObject assasino;

    public override void exclusivo()
    {
        // Tirar assasino
        assasino.SetActive(false);
        GameStatus.assasino = false;
    }
}
