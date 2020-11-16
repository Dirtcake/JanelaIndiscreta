using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inColagem : inBase
{
    [FMODUnity.EventRef]
    public string ColagemInt;
    FMOD.Studio.EventInstance ePainting;

    [FMODUnity.EventRef]
    public string Colagem2Int;
    FMOD.Studio.EventInstance ePainting2;

    public Material materialColagem;
    public GameObject quadroUm, quadroDois;

    public GameObject JanelaCam;
    public GameObject niveis;

    private int level = 1;

    public override void updateCapsule()
    {
        if (JanelaCam.active == true && GameStatus.targetAction == actionName)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                interagindo = true;
                nivelPista += 1 * Time.deltaTime;
                niveis.transform.GetChild(0).GetComponent<Slider>().value = nivelPista;

            }
            else
            {
                interagindo = false;
            }
        }
    }
    public override void exclusivo()
    {
        /* // trocar imagens dos quadros
         quadroUm.GetComponent<MeshRenderer>().material = materialColagem;
         quadroDois.GetComponent<MeshRenderer>().material = materialColagem;
        */

        // Setar emiter do som
        ePainting = FMODUnity.RuntimeManager.CreateInstance(ColagemInt);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(ePainting, GetComponent<Transform>(), GetComponent<Rigidbody>());

        ePainting2 = FMODUnity.RuntimeManager.CreateInstance(Colagem2Int);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(ePainting2, GetComponent<Transform>(), GetComponent<Rigidbody>());

        // Play no som
        ePainting.start();
        ePainting2.start();

        GameStatus.pista = true;

        JanelaCam.SetActive(true);
        niveis.SetActive(true);
        niveis.transform.GetChild(0).gameObject.SetActive(true);

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
