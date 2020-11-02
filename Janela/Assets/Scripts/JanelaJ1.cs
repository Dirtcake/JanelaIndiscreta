using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JanelaJ1 : MonoBehaviour
{
    public GameObject photoNeighbourhood;
    public Camera cameraVizinho;

    public bool janelaAberta;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && janelaAberta == true)
        {
            cameraVizinho.gameObject.SetActive(false);
            janelaAberta = false;
        }
    }
    public void OnTriggerStay(Collider other)
    {
        //print("pode apertar sem medo");
        if (Input.GetMouseButtonDown(2))
        {
            print("varias");
            cameraVizinho.gameObject.SetActive(true);
            janelaAberta = true;

        }
    }
}
