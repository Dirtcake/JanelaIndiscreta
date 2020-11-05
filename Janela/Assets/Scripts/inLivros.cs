using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inLivros : inBase
{
    private int level = 1;
    public override void exclusivo()
    {
        switch (level)
        {
            case 1:
                GameStatus.tempo += (60 * 2);
                level++;
                break;
            case 2:
                GameStatus.tempo += (60 * 4);
                level++;
                break;
            case 3:
                GameStatus.tempo += (60 * 6);
                level++;
                break;
        }
    }
}
