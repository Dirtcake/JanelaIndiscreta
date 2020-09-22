using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteInteracao : MonoBehaviour,iInteragivel
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void acao()
    {
        Debug.Log(gameObject.name);
    }
}
