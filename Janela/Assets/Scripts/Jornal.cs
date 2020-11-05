using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jornal : MonoBehaviour
{
    private int page = 1;
    private void OnEnable()
    {
        page = 1;
    }

    void Update()
    {
        switch (page)
        {
            case 1:
                break;
            case 2:
                break;
        }

        // Este é o unico codigo em funcionamento
        if (Input.GetButtonDown("Cancel"))
        {
            gameObject.SetActive(false);
            GameStatus.PlayerMovement = true;
            Cursor.visible = false;
        }
    }
    public void BotaoEsquerdo() 
    {
        if (page != 1) page--;

    }
    public void BotaoDireito()
    {
        if (page != 2) page++;
        print("Saindo");

    }
    public void BotaoFechar()
    {
        print("Saindo");
        gameObject.SetActive(false);
        GameStatus.PlayerMovement = true;
    }

}
