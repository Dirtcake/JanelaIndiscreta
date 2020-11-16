using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class inRadio : inBase
{
    private int level = 1;

    public GameObject JanelaCam;
    public GameObject niveis;

    public override void updateCapsule()
    {
        if (JanelaCam.active == true && GameStatus.targetAction == actionName)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                interagindo = true;
                nivelPista += 1 * Time.deltaTime;
                niveis.transform.GetChild(2).GetComponent<Slider>().value = nivelPista;

            }
            else
            {
                interagindo = false;
            }
        }
    }
    public override void exclusivo()
    {
        JanelaCam.SetActive(true);
        niveis.SetActive(true);
        niveis.transform.GetChild(2).gameObject.SetActive(true);


        switch (level)
        {
            case 1:
                GameStatus.tempo += (60 * 2);
                level++;
                break;
            case 2:
                GameStatus.tempo += (60 * 4);
                level++;
                break;
            case 3:
                GameStatus.tempo += (60 * 6);
                level++;
                break;
        }
    }
}
