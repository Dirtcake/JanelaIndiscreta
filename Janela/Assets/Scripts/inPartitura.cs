using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inPartitura : inBase
{
    public override void exclusivo()
    {
        GameStatus.partituras++;
    }
}
