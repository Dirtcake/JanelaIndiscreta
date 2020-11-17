using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relogio : MonoBehaviour
{
    public GameObject relogio;
    public void OnMouseEnter()
    {
        Debug.Log("ta em cima ");
        relogio.SetActive(true);
    }
    private void OnMouseExit()
    {
        Debug.Log("relogio");
        relogio.SetActive(false);
    }
}
