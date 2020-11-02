using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TesteCamera : MonoBehaviour
{
    public static int comodo;
    public Vector3[] comodos;

    public float t;
    void Update()
    {
        Vector3 posicao = transform.position;

            posicao = Vector3.Lerp(transform.position, comodos[comodo], t);
            //print(posicao);
            transform.position = posicao;
       
    }
}
