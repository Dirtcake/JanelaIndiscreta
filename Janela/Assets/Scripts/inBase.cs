using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inBase : MonoBehaviour,iInteragivel
{
    public string actionName = "Alterar no InBase";
    public bool On = false;

    protected float distance = 1.5f;

    protected bool StatusPista;         // Amazena se a pista está feita ou não

    void Start()
    {
        startCapsule();
    }

    void Update()
    {
        updateCapsule();
        if (On)
        {
            //print(Vector3.Distance(GameStatus.Player.transform.position, transform.position));
            print(GameStatus.targetAction);

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
