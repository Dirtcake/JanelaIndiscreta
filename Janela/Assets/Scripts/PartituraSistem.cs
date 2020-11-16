using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartituraSistem : MonoBehaviour
{


    public static bool on = true;
    
    void Start()
    {
        SpawnarPartitura();
    }

    void Update()
    {
        
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
