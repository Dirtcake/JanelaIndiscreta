using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class inRadio : inBase
{
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
        if (GameStatus.dia >= 2)
        {


            JanelaCam.SetActive(true);
            niveis.SetActive(true);
            niveis.transform.GetChild(2).gameObject.SetActive(true);

        }
    }
}
