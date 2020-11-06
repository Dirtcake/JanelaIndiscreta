using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Period : MonoBehaviour
{
    public Vector3 amanhecer, por, anoitecer;
    float contador;
    public enum horarios
    {
        manha,
        tarde,
        noite
    }
    public horarios dia;

    private void Update()
    {

        contador += Time.deltaTime;
        if (contador >= 1)
        {
            GameStatus.tempo += 1;
            Debug.Log("acrescentou " + GameStatus.tempo);
            contador = 0;
        }

        switch (dia)
        {
            case horarios.manha:
                transform.localRotation = Quaternion.Euler(amanhecer.x, 0, 0);
                break;
            case horarios.tarde:
                transform.localRotation = Quaternion.Euler(por.x, 0, 0);
                break;
            case horarios.noite:
                transform.localRotation = Quaternion.Euler(anoitecer.x, 0, 0);
                break;
        }

        #region tempo

        if (GameStatus.tempo <= 60)
            dia = horarios.manha;

        if (GameStatus.tempo >= 61 && GameStatus.tempo <= 120)
            dia = horarios.tarde;

        if (GameStatus.tempo >= 121 && GameStatus.tempo <= 180)
            dia = horarios.noite;

        if (GameStatus.tempo >= 181)
            GameStatus.tempo = 0;

        #endregion
    }
}
