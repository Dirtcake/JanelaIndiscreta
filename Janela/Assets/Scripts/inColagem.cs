﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inColagem : inBase
{
    public Material materialColagem;
    public GameObject quadroUm, quadroDois;

    private int level = 1;
    public override void exclusivo()
    {
       /* // trocar imagens dos quadros
        quadroUm.GetComponent<MeshRenderer>().material = materialColagem;
        quadroDois.GetComponent<MeshRenderer>().material = materialColagem;
       */

        GameStatus.pista = true;

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
