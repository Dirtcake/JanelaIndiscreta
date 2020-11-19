using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartituraSistem : MonoBehaviour
{
    public GameObject partituraHUD;

    public static bool on = true;
    
    void Start()
    {
        SpawnarPartitura();
    }

    void Update()
    {
        if (GameStatus.partituras != 0)
        {
            partituraHUD.SetActive(true);
        }
        else partituraHUD.SetActive(false);
    }

    public  void SpawnarPartitura()
    {
        if (on)
        {
            transform.GetChild((int)Random.Range(0,2)).GetComponent<inPartitura>().partitura = true;
            on = false;
        }
    }
}
