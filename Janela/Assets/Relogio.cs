using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relogio : MonoBehaviour
{
    public GameObject relogio;

    public Transform ponteiroHorasZ, ponteirosMinutosZ;
    public Vector3 startedAnglesHoras, startedAnglesMinutos;
    public float angleFactorH, angleFactorM;

    public void Start()
    {
        startedAnglesHoras = ponteiroHorasZ.transform.localEulerAngles;
        startedAnglesMinutos = ponteirosMinutosZ.transform.localEulerAngles;
    }
    public void Update()
    {
        ponteiroHorasZ.transform.localEulerAngles = new Vector3(startedAnglesHoras.x, startedAnglesHoras.y, startedAnglesHoras.z - GameStatus.tempo*angleFactorH ) ;
        ponteirosMinutosZ.transform.localEulerAngles = new Vector3(startedAnglesMinutos.x, startedAnglesMinutos.y, startedAnglesMinutos.z - GameStatus.tempo * angleFactorM);

        if (Input.GetKeyDown("space"))
            GameStatus.tempo = 895;
    }
    #region mouse
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
    #endregion
}
