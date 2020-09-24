using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inPiano : inBase
{
    public GameObject assasino, observador,perdestes, ganhastes;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public override void exclusivo()
    {
        // aparece o assasino e o observador
       
        if(GameStatus.assasino == true && GameStatus.pista == true )
        {
            perdestes.SetActive(true);
            Time.timeScale = 0;

        }

        else if (GameStatus.assasino == false && GameStatus.pista == true && GameStatus.observador == true)
        {
            ganhastes.SetActive(true);
            Time.timeScale = 0;
        }

        assasino.SetActive(true);
        observador.SetActive(true);

        GameStatus.assasino = true;
        GameStatus.observador = true;

    }
}
