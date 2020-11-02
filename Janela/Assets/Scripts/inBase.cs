using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inBase : MonoBehaviour,iInteragivel
{

    public GameObject feedBack;

    public string actionName = "Alterar no InBase";
    public bool On = false;

    protected float distance = 1.5f;

    void Start()
    {
        feedBack = GameObject.FindGameObjectWithTag("UI");   
    }

    void Update()
    {

        if (On)
        {
            print(Vector3.Distance(GameStatus.Player.transform.position, transform.position));
            print(GameStatus.targetAction);

            if (GameStatus.targetAction == null) On = false;

            if (actionName == GameStatus.targetAction && Vector3.Distance(GameStatus.Player.transform.position, transform.position) < distance)
            {
                feedBack.GetComponent<Text>().text = "Ação Concluida: " + this.name;
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
}
