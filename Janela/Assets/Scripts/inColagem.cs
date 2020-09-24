using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inColagem : inBase
{
    public Material materialColagem;
    public GameObject quadroUm, quadroDois;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public override void exclusivo()
    {
        // trocar imagens dos quadros
        quadroUm.GetComponent<MeshRenderer>().material = materialColagem;
        quadroDois.GetComponent<MeshRenderer>().material = materialColagem;

        GameStatus.pista = true;
    }
}
