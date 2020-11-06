using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLocal : MonoBehaviour
{
    public Vector3 salaV, salaEV, cozinhaV, banheiroV, quartoV;
    public GameObject salaC, salaEC, cozinhaC, banheiroC, quartoC;
    public enum comodos
    {
        sala,
        salaExtremo,
        cozinha,
        banheiro,
        quarto
    }
    public comodos casa;

    private void Update()
    {

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

        }

        void OntriggerEnter(Collider col)
        {
            if (col.gameObject.CompareTag("salaE"))
                casa = comodos.salaExtremo;

            if (col.gameObject.CompareTag("cozinha"))
                casa = comodos.cozinha;

            if (col.gameObject.CompareTag("banheiro"))
                casa = comodos.banheiro;

            if (col.gameObject.CompareTag("quarto"))
                casa = comodos.quarto;

            if (col.gameObject.CompareTag("sala"))
                casa = comodos.sala;

        }
    }
}
