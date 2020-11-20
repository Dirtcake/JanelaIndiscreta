using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inLivros : inBase
{
    [FMODUnity.EventRef]
    public string LivrosInt;
    FMOD.Studio.EventInstance eBook;

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
                niveis.transform.GetChild(1).GetComponent<Slider>().value = nivelPista;

            }
            else
            {
                interagindo = false;
            }
        }
    }

    public override void exclusivo()
    {
        /*// Setar emiter do som
        eBook = FMODUnity.RuntimeManager.CreateInstance(LivrosInt);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(eBook, GetComponent<Transform>(), GetComponent<Rigidbody>());

        // Play no som
        eBook.start();*/

        JanelaCam.SetActive(true);
        niveis.SetActive(true);
        niveis.transform.GetChild(1).gameObject.SetActive(true);

    }
}
