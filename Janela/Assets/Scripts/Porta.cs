using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    bool dentro = false;
    public GameObject porta;
    public static bool passou;



    public void OnTriggerStay(Collider other)
    {
        TesteCamera.comodo = 1;
    }
    public void OnTriggerExit(Collider other)
    {
        TesteCamera.comodo = 0;
    }
}

