using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inBase : MonoBehaviour,iInteragivel
{
    public string actionName = "Alterar no InBase";

    protected float distance = 1.5f;
    public float nivelPista;            // Nivel em que pista se encontra

    protected bool StatusPista;         // Amazena se a pista está feita ou não
    public bool On = false;
    public static bool interagindo;            // Indica se o jogador está fazendo a pista ou não

    void Start()
    {
        startCapsule();
    }

    void Update()
    {
        //print(GameStatus.targetAction);
        //Quando o observador está te olhando, a barra de suspeita sobe mais rapido
        if (GameStatus.olhando && interagindo)
        {
            GameStatus.acrescimoNivelSuspeita = 0.09f;
            print(GameStatus.acrescimoNivelSuspeita);
        }
        else GameStatus.acrescimoNivelSuspeita = 0.01f;

        updateCapsule();
        if (On)
        {
            //print(Vector3.Distance(GameStatus.Player.transform.position, transform.position));
            //print(GameStatus.targetAction);

            if (GameStatus.targetAction == null) On = false;

            if (actionName == GameStatus.targetAction && Vector3.Distance(GameStatus.Player.transform.position, transform.position) < distance)
            {
                GameStatus.FeedBackConclusao.SetActive(true);
                exclusivo();
                On = false;
            }
        }
    }

    public virtual void acao()
    { 
        On = true;

        GameStatus.targetAction = actionName;
    }

    public virtual void exclusivo() { }
    public virtual void updateCapsule() { }
    public virtual void startCapsule() { }


}
