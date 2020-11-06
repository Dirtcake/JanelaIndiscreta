﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLocal : MonoBehaviour
{
    public Vector3 salaV, salaEV, cozinhaV, banheiroV, quartoV, janelaV;
    public GameObject salaC, salaEC, cozinhaC, banheiroC, quartoC, janelaC;
    public enum comodos
    {
        sala,
        salaExtremo,
        cozinha,
        banheiro,
        quarto,
        janela
    }
    public comodos casa;

    public void Start()
    {
        
    }
    private void Update()
    {
        if(Camera.main.transform.position == janelaV)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
                Camera.main.transform.position = salaV;
        }

        switch (casa)
        {
            case comodos.sala:
                Camera.main.transform.position = salaV;
                break;
            case comodos.salaExtremo:
                Camera.main.transform.position = salaEV;
                break;
            case comodos.cozinha:
                Camera.main.transform.position = cozinhaV;
                break;
            case comodos.banheiro:
                Camera.main.transform.position = banheiroV;
                break;
            case comodos.quarto:
                Camera.main.transform.position = quartoV;
                break;
            case comodos.janela:
                Camera.main.transform.position = janelaV;
                break;

        }

       
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("a");

        if (collision.gameObject.CompareTag("salaE"))
            casa = comodos.salaExtremo;

        if (collision.gameObject.CompareTag("cozinha"))
            casa = comodos.cozinha;

        if (collision.gameObject.CompareTag("banheiro"))
            casa = comodos.banheiro;

        if (collision.gameObject.CompareTag("quarto"))
            casa = comodos.quarto;

        if (collision.gameObject.CompareTag("sala"))
            casa = comodos.sala;
        if (collision.gameObject.CompareTag("janela"))
            casa = comodos.janela;
    }
}
