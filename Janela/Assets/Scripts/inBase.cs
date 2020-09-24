using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inBase : MonoBehaviour,iInteragivel
{

    public GameObject feedBack;

    void Start()
    {
        feedBack = GameObject.FindGameObjectWithTag("UI");   
    }

    void Update()
    {
        
    }

    public virtual void acao()
    {
        feedBack.GetComponent<Text>().text = "Ação Concluida: " + this.name;
        exclusivo();
    }

    public virtual void exclusivo() { }
}
